﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow_3 : MonoBehaviour
{
    [Header("摄像机跟随偏移")]
    public Vector2 offset;
    public float xRange = 0.5f;
    public float smoothSpeed = 0.15f;
    void Start()
    {
        
    }

    
    void Update()
    {
        float dx = 0;
        if (snakemanager_mode3.instance.snakeHead_3)
        {
            dx = snakemanager_mode3.instance.snakeHeadPosX;
            Vector3 desiredPos = new Vector2(dx, 0) + offset;
            desiredPos.z = transform.position.z;
            if (desiredPos.x + xRange > transform.position.x)
            {
                transform.position = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);
            }
        }
    }
}
