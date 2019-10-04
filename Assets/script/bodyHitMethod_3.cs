using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyHitMethod_3 : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag =="food"&&transform ==snakemanager_mode3 .instance .snakeHead_3 )
        {
            int food = col.GetComponent<foodDestroy>().energy;
            for (int i = 0; i < food; i++)
                GetComponentInParent<snakemanager_mode3>().SpawnBody_3();
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        //处理蛇头碰撞Block
        if(col.gameObject .tag =="block")
        {
            if(snakemanager_mode3 .instance .snakeBodyList_mode3 .Count ==1)
            {
                snakemanager_mode3.instance.UpdateText(-1);
                col.transform.GetComponent<BlockDestroy_3>().SetBlockColorAndText(-1);
                snakemanager_mode3.instance.textMesh.transform.parent = null;
                Destroy(snakemanager_mode3.instance.snakeBodyList_mode3[0].gameObject);
                snakemanager_mode3.instance.snakeBodyList_mode3.Remove(snakemanager_mode3.instance.snakeBodyList_mode3[0]);
                GM_mode3.instance.UpdateScore (1);
                GM_mode3.instance.GameOver();
            }
            else
            {
                if(transform ==snakemanager_mode3 .instance .snakeHead_3 )
                {
                    snakemanager_mode3.instance.UpdateText(-1);
                    col.transform.GetComponent<BlockDestroy_3>().SetBlockColorAndText(-1);
                    snakemanager_mode3.instance.textMesh.transform.position = snakemanager_mode3.instance.snakeBodyList_mode3[1].position+ new Vector3(0.5f, 0, 0);
                    snakemanager_mode3.instance.textMesh.transform.parent = snakemanager_mode3.instance.snakeBodyList_mode3[1];
                    snakemanager_mode3.instance.snakeHeadR2D_3 = snakemanager_mode3.instance.snakeBodyList_mode3[1].GetComponent<Rigidbody2D>();
                    snakemanager_mode3.instance.snakeBodyList_mode3[1].GetComponent<SpriteRenderer>().sprite = snakemanager_mode3.instance.headSprite;
                    //删除蛇头
                    Destroy(snakemanager_mode3.instance.snakeBodyList_mode3[0].gameObject);
                    snakemanager_mode3.instance.snakeBodyList_mode3.Remove(snakemanager_mode3.instance.snakeBodyList_mode3[0]);
                    GM_mode3.instance.UpdateScore(1);
                }
                else
                {
                    Physics2D.IgnoreCollision(GetComponent<Collider2D>(), col.transform.GetComponent<Collider2D>());
                }
            }
            //播放声音
              
        }
    }
}
