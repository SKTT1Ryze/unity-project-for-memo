using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange_4 : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag =="bluegate_4")
        {
            transform.GetComponent<SpriteRenderer>().color = col.GetComponent<SpriteRenderer>().color;
            snakemanager_4.instance.snakeColor_4 = snakemanager_4.snakeColor.blue;
        }
        if (col.tag == "yellowgate_4")
        {
            transform.GetComponent<SpriteRenderer>().color = col.GetComponent<SpriteRenderer>().color;
            snakemanager_4.instance.snakeColor_4 = snakemanager_4.snakeColor.yellow ;
        }
        if (col.tag == "redgate_4")
        {
            transform.GetComponent<SpriteRenderer>().color = col.GetComponent<SpriteRenderer>().color;
            snakemanager_4.instance.snakeColor_4 = snakemanager_4.snakeColor.red ;
        }
        if (col.tag == "greengate_4")
        {
            transform.GetComponent<SpriteRenderer>().color = col.GetComponent<SpriteRenderer>().color;
            snakemanager_4.instance.snakeColor_4 = snakemanager_4.snakeColor.green ;
        }
    }
}
