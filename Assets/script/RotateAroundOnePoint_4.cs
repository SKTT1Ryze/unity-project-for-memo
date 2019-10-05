using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundOnePoint_4 : MonoBehaviour
{
    [Header("旋转的中心点")]
    public Transform rotateAtPoint;
    [Header("旋转速度")]
    public float rotateSpeed=2f;
    void Start()
    {
        
    }

    
    void Update()
    {
        if(rotateAtPoint )
        {
            transform.RotateAround(rotateAtPoint.position, new Vector3(0f, 0f, 1f), rotateSpeed * Time.smoothDeltaTime);
        }
        
    }
}
