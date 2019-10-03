using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    public float speed = 0.5f;
    private Vector3 mousepos;
    private Vector3 mouseworldpos;
    private float dist;
    

    private void Start()
    {
        
    }
    private void Update()
    {
        Vector3 v3 = Camera.main.WorldToScreenPoint(transform.position);
        mousepos = Input.mousePosition;
        mousepos.z = v3.z;
        mouseworldpos = Camera.main.ScreenToWorldPoint(mousepos);
        //Debug.Log("this:" + transform.position);
        //Debug.Log("mouse:" + mouseworldpos);
        dist = Vector3.Distance(mouseworldpos ,transform .position  );
        if (dist > 0.5f)
        {
            this.transform.Translate((mouseworldpos  - transform .position ) * Time.deltaTime * speed, Space.World);

        }
    }
}
