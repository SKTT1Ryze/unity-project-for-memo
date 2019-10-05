using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM_4 : MonoBehaviour
{
    public static  GM_4 instance;
    [Header("水平速度")]
    public float xspeed;
    [Header("蛇头跟随鼠标的速度")]
    public float yspeed;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
