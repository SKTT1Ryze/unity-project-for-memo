using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snakemanager : MonoBehaviour
{
    public static snakemanager instance;
    [Header ("贪吃蛇预制件")]
    public GameObject snakeprefab;
    [Header ("贪吃蛇身体List")]
    public List<Transform> snakebodylist = new List<Transform>();
    private float speed;
    //获取游戏管理器
    public GM gamemanager;
    public float lerp = 0.1f;
    //当前鼠标在世界坐标中的位置
    private Vector3 currentmousepos;
    //贪吃蛇和鼠标的距离 
    private Vector2 deltadistance;
    [Header("贪吃蛇初始身体数量")]
    public int bodyamount = 3;
    [Header ("贪吃蛇刚体")]
    public Rigidbody2D snakeheadR2d;
    //是否已经创建头部
    private bool havehead;
    //获取头部transform
    public Transform snakehead
    {
        get
        {
            if (snakebodylist.Count > 0 && snakebodylist[0])
                return snakebodylist[0];
            else
                return null;
        }
    }

    //获得蛇头当前位置坐标
    public Vector3  snakeheadpos
    {
        get
        {
            if (snakebodylist.Count > 0 && snakebodylist[0])
                return snakebodylist[0].position ;
            else
                return Vector3 .zero ;
        }
    }

    private void Awake()
    {
        instance = this;
        
    }
    void Start()
    {
        gamemanager = GM.instance;
        speed = gamemanager.speed;
        for (int i = 0; i < bodyamount; i++)
            Invoke("SpawnBody", 0.1f);
    }
    public void SpawnBody()
    {
        if(!havehead )
        {
            havehead = true;
            bodyamount = 0;
            Transform newbodypart = Instantiate(snakeprefab, Vector3.zero, Quaternion.identity, transform).GetComponent<Transform>();
            snakebodylist.Add(newbodypart);
            snakeheadR2d = snakehead.GetComponent<Rigidbody2D>();
        } else
        {
            Transform newbodypart = Instantiate(snakeprefab, snakebodylist [snakebodylist .Count -1].position +new Vector3 (0,-0.5f,0),snakebodylist [snakebodylist .Count -1].rotation , transform).GetComponent<Transform>();
            snakebodylist.Add(newbodypart);
        }
        bodyamount++;
    }

    private void FixedUpdate()
    {
        
    }
    void Update()
    {
        //获取鼠标在世界坐标中的位置
        currentmousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        deltadistance = (Vector2 ) currentmousepos - snakeheadR2d.position;
        float dist= Vector3.Distance(currentmousepos, snakeheadR2d.position);
        if (dist > 0.5f)
        {
            snakehead .Translate(((Vector2)currentmousepos - snakeheadR2d.position) * Time.deltaTime * speed, Space.World);

        }
        /*if (snakeheadR2d )
        {
            snakehead.transform.Translate(Vector2.up * speed * Time.smoothDeltaTime);
        }*/
    }
}
