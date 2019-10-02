using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyrotate : MonoBehaviour
{
    public GameObject head;
    public float rotatespeed = 1f;
    private Vector3 mouse_position;
    private Vector3 this_position;
    private Vector3 head_position;
    private Vector3 frontvector;
    private Vector3 followedvector;

    private void Start()
    {
        
    }
    private void Update()
    {
        /*mouse_position.x = Input.mousePosition.x - Screen.width * 0.5f;
        mouse_position.y = Input.mousePosition.y - Screen.height * 0.5f;
        mouse_position.z = transform.position.z;*/
        mouse_position = Input.mousePosition;
        this_position = Camera.main.WorldToScreenPoint(transform.position);
        head_position= Camera.main.WorldToScreenPoint(head.transform .position );
        frontvector = mouse_position  - head_position ;
        followedvector = head_position-this_position ;
        Debug.Log("angle:"+Vector3.Dot(frontvector, followedvector));
        if(Vector3 .Dot (frontvector ,followedvector )<0f||Vector3 .Dot (frontvector ,followedvector )>50f)
        {
            transform.RotateAround(head.transform.position, new Vector3(0f, 0f, 1f), rotatespeed*0.5f);

        }
    }
}
