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
    public float lerp = 2f;
    //当前鼠标在世界坐标中的位置
    private Vector3 currentmousepos;
    //贪吃蛇和鼠标的距离 
    private Vector2 deltadistance;
    [Header("贪吃蛇初始身体数量")]
    public int bodyamount = 3;
    [Header ("贪吃蛇刚体")]
    public Rigidbody2D snakeheadR2d;
    //是否已经创建头部
    private bool havehead=false ;
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

    //存储上一次鼠标的坐标
    private Vector3 previousmousepos;
    //鼠标是否移动
    private bool Ismousemove;
    private Vector3 previousvector;
    private float previousdistance;

    private void Awake()
    {
        instance = this;
        
    }
    void Start()
    {
        Ismousemove = true ;
        previousmousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
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
        Ismousemove = Vector3.Distance (currentmousepos ,previousmousepos )>1E-03f;
        //Debug.Log("distance:" + Vector3.Distance(currentmousepos, previousmousepos));
        //Debug.Log("Ismousemove:" + Ismousemove);
        if(snakeheadR2d &&Ismousemove )
        {
            //头部移动
            deltadistance = (Vector2)currentmousepos - snakeheadR2d.position;
            float dist = Vector2.Distance(currentmousepos, snakeheadR2d.position);
            if (dist>0.001f)
            {
                snakehead.Translate(((Vector2)currentmousepos - snakeheadR2d.position)/dist  * Time.deltaTime * speed, Space.World);

            }
            //snakehead.Translate(((Vector2)currentmousepos - snakeheadR2d.position) / dist * Time.deltaTime * speed, Space.World);
            bodymove();
            previousvector = deltadistance;
            previousdistance = dist;
        }
        else if (snakeheadR2d)
        {
            //头部移动
  
            //deltadistance = (Vector2)previousmousepos - snakeheadR2d.position;

            //transform.Translate(previousvector * Time .deltaTime/previousdistance *speed  ,Space.World);

            transform.Translate(Vector2.up *Time .deltaTime , Space.World);

            /*float k = (snakehead.position.y - snakebodylist[1].position .y) / (snakehead.position.x - snakebodylist[1].position.x);
            Debug.Log("k:" + k);
            transform.position += new Vector3(Time .deltaTime *speed , k*Time .deltaTime*speed  ,0);*/
            bodymove();
        }
            
        
        previousmousepos = currentmousepos;
       
    }
    //蛇身体其他部分随头部移动
    void bodymove()
    {
        for (int i = 1; i < snakebodylist.Count; i++)
        {
            Vector2 previouspos = snakebodylist[i - 1].position;
            Vector2 currentpos = snakebodylist[i].position;
            /*if(Vector2 .Distance (previouspos, currentpos)>0.8f)
            {
                snakebodylist[i].position = Vector2.Lerp(snakebodylist[i].position, previouspos, lerp * Time.smoothDeltaTime);
            }*/
            snakebodylist[i].position = Vector2.Lerp(snakebodylist[i].position, previouspos, lerp * Time.smoothDeltaTime);
        }
    }
}
