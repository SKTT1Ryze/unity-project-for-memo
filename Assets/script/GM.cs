 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    public static GM instance;
    [Header ("贪吃蛇初始移动速度变量")]  
    public float speed;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        speed = 5f;
    }

    void Update()
    {
        
    }
    
}
