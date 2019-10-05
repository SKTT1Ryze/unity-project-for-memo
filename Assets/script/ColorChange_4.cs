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
        if(col.tag =="gate_4")
        {
            transform.GetComponent<SpriteRenderer>().color = col.GetComponent<SpriteRenderer>().color;
        }
    }
}
