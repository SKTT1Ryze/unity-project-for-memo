using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snakemanager_4 : MonoBehaviour
{
    public static snakemanager_4 instance;
    [Header("贪吃蛇预制件")]
    public GameObject snakePrefab_4;
    [Header ("贪吃蛇身体List")]
    public List<Transform> snakeBodyList_4 = new List<Transform>();
    float xspeed_4, yspeed_4;
    //获取游戏管理器
    GM_4 gamemanager_4;
    [Header ("蛇身体部位跟随速度")]
    public float  lerp_4=10f;
    //当前鼠标在世界坐标中的位置
    Vector3 currentMousePos_4;
    float upLimit_4, downLimit_4;
    //贪吃蛇和鼠标点击点的距离
    Vector2 deltaDistance_4;
    [Header("贪吃蛇身体数量")]
    public int bodyAmount_4=8;
    [Header("贪吃蛇头部rigibody")]
    public Rigidbody2D snakeHeadR2d_4;
    //是否拥有头部
    private bool IsHaveHead_4;
    //获取头部transform
    public Transform snakeHead_4
    {
        get
        {
            if (snakeBodyList_4.Count > 0 && snakeBodyList_4[0])
                return snakeBodyList_4[0];
            else
                return null;
        }
    }
    //获取头部当前X坐标值
    public float  snakeHeadPoX_4
    {
        get
        {
            if (snakeBodyList_4.Count > 0 && snakeBodyList_4[0])
                return snakeBodyList_4[0].position .x;
            else
                return 0 ;
        }
    }
    
     public enum snakeColor
    {
        blue,
        green,
        yellow,
        red
    }
    public snakeColor snakeColor_4;

    private void Awake()
    {
        instance = this;
        
    }
    void Start()
    {
        snakeColor_4 = snakeColor.blue;
        IsHaveHead_4 = false;
        gamemanager_4 = GM_4.instance;
        xspeed_4 = gamemanager_4.xspeed;
        yspeed_4 = gamemanager_4.yspeed;
        for (int i=0;i<bodyAmount_4;i++)
        {
            //Debug.Log("Spawn");
            Invoke("SpawnBody_4", 0.1f);
        }
    }
    public void SpawnBody_4()
    {
        if(!IsHaveHead_4 )
        {
            IsHaveHead_4 = true;
            bodyAmount_4 = 0;
            Transform newBodyPart = Instantiate(snakePrefab_4, Vector3.zero, Quaternion.identity,transform ).GetComponent <Transform >();
            snakeBodyList_4.Add(newBodyPart);
            snakeHeadR2d_4 = snakeHead_4.GetComponent<Rigidbody2D>();
        }else
        {
            Transform newBodyPart = Instantiate(snakePrefab_4, snakeBodyList_4 [snakeBodyList_4 .Count -1].position +new Vector3 (-0.5f,0,0), Quaternion.identity, transform).GetComponent<Transform>();
            snakeBodyList_4.Add(newBodyPart);
        }
    }


    void Update()
    {
        if(snakeHeadR2d_4 )
        {
            snakeHead_4.transform.Translate(Vector2.right * xspeed_4 * Time.smoothDeltaTime);
            currentMousePos_4 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //头部移动
            float dist = Vector2.Distance(currentMousePos_4, snakeHead_4.position);
            if (dist > 0.001f&&currentMousePos_4 .x > snakeHead_4.position.x)
            {
                snakeHead_4.Translate(((Vector2)currentMousePos_4 - snakeHeadR2d_4 .position) / dist * Time.deltaTime * xspeed_4, Space.World);

            }
            BodyMove_4();
        }
    }
    //蛇身体其他部分跟随移动
    void BodyMove_4()
    {
        for (int i = 1; i < snakeBodyList_4 .Count; i++)
        {
            Vector2 previouspos = snakeBodyList_4[i - 1].position;
            Vector2 currentpos = snakeBodyList_4[i].position;
            /*if(Vector2 .Distance (previouspos, currentpos)>0.8f)
            {
                snakebodylist[i].position = Vector2.Lerp(snakebodylist[i].position, previouspos, lerp * Time.smoothDeltaTime);
            }*/
            snakeBodyList_4[i].position = Vector2.Lerp(snakeBodyList_4[i].position, previouspos, lerp_4 * Time.smoothDeltaTime);
        }
    }
}
