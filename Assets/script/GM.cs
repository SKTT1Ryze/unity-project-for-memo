 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    public static GM instance;
    [Header ("贪吃蛇移动速度变量")]  
    public float speed;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        speed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
