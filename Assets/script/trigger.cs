﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    private int count;
    private void Start()
    {
        
    }
    private void Update()
    {
        
    }
    /* void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("on collision");
    }*/
    private void OnTriggerEnter2D(Collider2D collision)
    {
        count++;
        Debug.Log("on trigger:"+count );
    }
}