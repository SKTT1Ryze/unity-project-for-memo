using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyrotate : MonoBehaviour
{
    public GameObject head;
    public float rotatespeed = 3f;
    private Vector3 rotatedirection;

    private void Start()
    {
        
    }
    private void Update()
    {
        transform.RotateAround(head.transform.position, new Vector3(0f, 0f, 1f),rotatespeed );
    }
}
