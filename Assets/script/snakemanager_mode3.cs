using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snakemanager_mode3 : MonoBehaviour
{
    public static snakemanager_mode3 instance; 
    [Header ("贪吃蛇预制件")]
    public GameObject snakeprefab_mode3;
    [Header ("贪吃蛇身体List")]
    public List<Transform> snakeBodyList_mode3 = new List<Transform>();
    private float xspeed, yspeed;
    //获取游戏管理器
    private GM_mode3 gamemanager_3;
    [Header ("贪吃蛇身体组成数量")]
    public TextMesh textMesh;
    [Header("贪吃蛇rigibody")]
    public Rigidbody2D snakeHeadR2D_3;
    public float ylerp_mode3 = 5f;
    //当前鼠标在世界坐标中的位置
    private Vector3 currentMousePos_3;
    private float upLimit, downLimit;
    //贪吃蛇和鼠标点击点的距离
    private  Vector2 deltaDistance_3;
    [Header("贪吃蛇初始身体长度")]
    public int bodyAmount_3 = 3;
    //是否已经创建头部
    private bool hasHead;
    //获取头部transform
    public Transform snakeHead_3
    {
        get
        {
            if(snakeBodyList_mode3 .Count >0&&snakeBodyList_mode3 [0])
            {
                return snakeBodyList_mode3[0];
            }
            else
            {
                return null;
            }
        }
    }
    //获取头部当前X坐标值
    public  float snakeHeadPosX
    {
        get
        {
            if (snakeBodyList_mode3.Count > 0 && snakeBodyList_mode3[0])
            {
                return snakeBodyList_mode3[0].position .x;
            }
            else
            {
                return 0;
            }
        }
    }

    [Header ("蛇头部的Sprite")]
    public Sprite headSprite;

    private void Awake()
    {
        instance = this;
        textMesh = GetComponentInChildren<TextMesh>();
        
    }
    void Start()
    {
        gamemanager_3 = GM_mode3.instance;
        xspeed = gamemanager_3.xspeed;
        yspeed = gamemanager_3.yspeed;
        upLimit = Camera.main.orthographicSize *Camera .main .aspect*0.5f-0.5f;
        downLimit = -Camera.main.orthographicSize*Camera .main.aspect*0.5f  + 0.5f;
        //upLimit = 4.9f;
        //downLimit = -4.9f;
        for (int i=0;i<bodyAmount_3;i++)
        {
            Invoke("SpawnBody_3", 0.1f);
            //分数初始化
            Invoke("ScoreInitialize", 0.1f);
        }
        

    }
    public void SpawnBody_3()
    {
        if(!hasHead )
        {
            hasHead = true;
            bodyAmount_3 = 0;
            Transform newBodyPart = Instantiate(snakeprefab_mode3, Vector3.zero, Quaternion.identity, transform).GetComponent<Transform>();
            snakeBodyList_mode3.Add(newBodyPart);
            textMesh.transform.position = snakeHead_3 .position + new Vector3(0.5f, 0, 0);
            textMesh.transform.parent = snakeHead_3;
            snakeHeadR2D_3 = snakeHead_3.GetComponent<Rigidbody2D>();
            snakeHead_3.GetComponent<SpriteRenderer>().sprite = headSprite;
        }else
        {
            Transform newBodyPart = Instantiate(snakeprefab_mode3, snakeBodyList_mode3[snakeBodyList_mode3 .Count -1].position +new Vector3 (-0.25f,0,0), snakeBodyList_mode3 [snakeBodyList_mode3 .Count -1].rotation , transform).GetComponent<Transform>();
            snakeBodyList_mode3.Add(newBodyPart);
        }
        //更新分数
        ScoreManager_3.instance.UpdateScore(10);
        UpdateText(1);
    }
    void ScoreInitialize()
    {
        //更新分数
        ScoreManager_3.instance.UpdateScore(-10);
    }
    //更新蛇数量UI
    public void UpdateText(int amount)
    {
        bodyAmount_3 += amount;
        textMesh.text = bodyAmount_3.ToString();
    }
    private void FixedUpdate()
    {
        if(snakeHeadR2D_3 )
        {
            snakeHeadR2D_3.AddForce(deltaDistance_3 * yspeed, ForceMode2D.Force);
        }
    }

    void Update()
    {
        if(snakeHead_3 )
        {
            snakeHead_3.transform.Translate(Vector2.right * xspeed * Time.smoothDeltaTime);
             if(Input .GetMouseButtonDown (0))
            {
                currentMousePos_3 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                //播放移动声音
            }
            deltaDistance_3 = (Vector2)currentMousePos_3 - snakeHeadR2D_3.position;
            if (deltaDistance_3.x < 0)
                deltaDistance_3.x = 0;
            deltaDistance_3.y = Mathf.Clamp(deltaDistance_3.y, downLimit , upLimit );
            Move_3();
        }

    }
    void Move_3()
    {
        for (int i = 1; i < snakeBodyList_mode3.Count; i++)
        {
            Vector2 previousPos = snakeBodyList_mode3[i - 1].position;
            Vector2 currentPos = snakeBodyList_mode3[i].position;
            snakeBodyList_mode3[i].position = Vector2.Lerp(currentPos , previousPos, ylerp_mode3 * Time.smoothDeltaTime);
        }
            
    }
}
