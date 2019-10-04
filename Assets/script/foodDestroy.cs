using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodDestroy : MonoBehaviour
{
    [Header("食物提供的能量")]
    public int energy;
    SpriteRenderer sr;
    private void Awake()
    {
        energy = Random.Range(1, 10);
        sr = GetComponent<SpriteRenderer>();
        GetComponentInChildren<TextMesh>().text = energy.ToString();
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        if (snakemanager_mode3.instance.snakeHead_3 && snakemanager_mode3.instance.snakeHeadPosX - transform.position.x > 10)
            Destroy(gameObject); 
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.transform ==snakemanager_mode3 .instance .snakeHead_3 )
        {
            //播放声音
            Destroy(gameObject);
        }
        if(col .tag=="block")
        {
            Destroy(gameObject);
        }
    }
}
