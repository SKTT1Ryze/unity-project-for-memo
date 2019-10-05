using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDestroy_4 : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (snakemanager_4.instance.snakeHeadPoX_4 - transform.position.x > 20f)
            Destroy(gameObject);
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        
        if(col.tag =="bluegate_4"|| col.tag == "redgate_4"|| col.tag == "yellowgate_4"|| col.tag == "greengate_4")
        {
            //Debug.Log("触发");
            Destroy(gameObject);
        }
            
    }
}
