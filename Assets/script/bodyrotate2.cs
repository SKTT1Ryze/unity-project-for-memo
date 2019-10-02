using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyrotate2 : MonoBehaviour
{
    public GameObject head;
    public float rotatespeed = 5f;
    private Vector3 mouse_position;
    private Vector3 mouse_worldposition;
    private Vector3 this_position;
    private Vector3 head_position;
    private Vector3 frontvector;
    private Vector3 followedvector;
    private float front_dis;
    private float followed_dis;
    private Vector3 cross;
    void Start()
    {
        
    }
    void Update()
    {
        this_position = transform.position;
        Vector3 v3 = Camera.main.WorldToScreenPoint(transform.position);
        mouse_position  = Input.mousePosition;
        mouse_position .z = v3.z;
        mouse_worldposition  = Camera.main.ScreenToWorldPoint(mouse_position );
        head_position = head.transform.position;
        //Debug.Log ("mouse,head,this" + mouse_worldposition + head_position + this_position);
        frontvector = mouse_worldposition - head_position;
        followedvector = head_position - this_position;
        front_dis = Vector3.Distance(mouse_worldposition, head_position);
        followed_dis = Vector3.Distance(head_position, this_position);
        //Debug.Log(Vector3.Dot(frontvector, followedvector));
        //Debug.Log(Vector3.Dot(frontvector, followedvector) / (front_dis * followed_dis));
        cross = Vector3.Cross(frontvector, followedvector);
        if (Vector3.Dot(frontvector, followedvector)< 0f || Vector3.Dot(frontvector, followedvector) / (front_dis * followed_dis)<0.999f)
        {
            if(cross .z >=0f)
            {
                transform.RotateAround(head.transform.position, new Vector3(0f, 0f, 1f), -rotatespeed);

            }
            if(cross .z <0f)
            {
                transform.RotateAround(head.transform.position, new Vector3(0f, 0f, 1f), rotatespeed);

            }
        }
    }
}
