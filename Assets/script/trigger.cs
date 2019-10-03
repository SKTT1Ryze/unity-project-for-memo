using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    private int count;
    private void Start()
    {
        count = 0;
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
            Debug.Log("boom");
        }
        else if(collision .tag=="energy")
        {
            Debug.Log("energy");
        }
        else if(collision .tag=="food")
        {
            Debug.Log("heart");

        }
        else if(collision .tag=="mushroom")
        {
            Debug.Log("mushroom");
        }
        else if(collision .tag=="poisonousgrass")
        {
            Debug.Log("posionousgrass");
        }
        else if (collision .tag=="shelld")
        {
            Debug.Log("shelld");
        }

    }

}
