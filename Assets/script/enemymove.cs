using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove : MonoBehaviour
{
    [Header ("敌人移动的速度")]
    public float monsterspeed;
    [Header ("敌人移动的范围")]
    public float moverange;
    void Start()
    {
        moverange = 5f;
    }

   
    void Update()
    {
        transform.position += Vector3.up * monsterspeed * Time.deltaTime;
        //超出范围
        if(transform.position .y>moverange ||transform .position .y<moverange *(-1f))
        {
            //反向
            monsterspeed = -monsterspeed;
        }
    }
}
