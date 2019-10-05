using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateRecycle_4 : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (snakemanager_4.instance.snakeHeadPoX_4 - transform.position.x > 20f)
            Destroy(gameObject);
    }
}
