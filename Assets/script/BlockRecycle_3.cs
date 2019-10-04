using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockRecycle_3 : MonoBehaviour
{
    
    void Update()
    {
        if (snakemanager_mode3.instance.snakeHead_3 && snakemanager_mode3.instance.snakeHeadPosX - transform.position.x > 10)
            Destroy(gameObject);
    }
}
