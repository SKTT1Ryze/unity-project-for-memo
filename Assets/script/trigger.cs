﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    //获得snakemanager脚本
    public snakemanager SM;
    private int count;
    [Header ("增加的速度")]
    public float deltaspeed;
    [Header("增加的跟随速度")]
    public float deltalerp;
    //存储当前贪吃蛇身体数量
    private int presentbodyamount;
    //是否有防御盾
    private bool Ishaveshelld;
    private void Start()
    {
        count = 0;
        SM = GetComponentInParent<snakemanager>();
        deltaspeed = 5f;
        deltalerp = 5f;
        Ishaveshelld = false;
        
    }
    private void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        count++;
        //Debug.Log("on trigger:"+count );
        if(collision .tag =="wall")
        {
            Debug.Log("Gameover" );
        }
        else if(collision .tag=="boom")
        {
            //Debug.Log("boom");
            Destroy(collision.GetComponent<SpriteRenderer>());
            Destroy(collision);
            if (Ishaveshelld )
            {
                Ishaveshelld = false;
                //盾牌UI消失
                return;
            }
            if(SM .bodyamount ==1)
            {
                //游戏结束
                Debug.Log("Gameover");
            }
            for(int i=0;i<=SM .bodyamount/2;i++)
            {
                SM.deletebody();
            }
            
        }
        else if(collision .tag=="energy")
        {
            //Debug.Log("energy");
            Destroy(collision.GetComponent<SpriteRenderer>());
            Destroy(collision);
            SM.speedchange(deltaspeed,deltalerp );
            Invoke("speeddown", 5f);

        }
        else if(collision .tag=="food")
        {
            //Debug.Log("food");
            Destroy(collision.GetComponent<SpriteRenderer>());
            Destroy(collision);
            SM.SpawnBody();

        }
        else if(collision .tag=="mushroom")
        {
            //Debug.Log("mushroom");
            Destroy(collision.GetComponent<SpriteRenderer>());
            Destroy(collision);
            presentbodyamount = SM.bodyamount;
            for (int i = 0; i <= presentbodyamount  ; i++)
            {
                SM.SpawnBody();
            }
        }
        else if(collision .tag=="poisonousgrass")
        {
            //Debug.Log("posionousgrass");
            Destroy(collision.GetComponent<SpriteRenderer>());
            Destroy(collision);
            if (Ishaveshelld)
            {
                Ishaveshelld = false;
                //盾牌UI消失
                return;
            }
            SM.deletebody();
            SM.deletebody();
        }
        else if (collision .tag=="shelld")
        {
            //Debug.Log("shelld");
            Destroy(collision.GetComponent<SpriteRenderer>());
            Destroy(collision);
            Ishaveshelld = true;
            //盾牌UI显现
        }

    }
    void speeddown()
    {
        SM.speedchange(-deltaspeed,-deltalerp );
    }
    

}
