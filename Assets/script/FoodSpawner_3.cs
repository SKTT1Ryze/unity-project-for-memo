using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner_3 : MonoBehaviour
{
    [Header("食物的预制件")]
    public GameObject foodPreFab_3;
    [Header("孵化的时间间隔")]
    public float interval_3=1f;
    [Header("孵化的概率")]
    public int rate_3 = 95;
    void Start()
    {
        InvokeRepeating("SpawnFood", 1, interval_3);
    }
    //产生新的食物
    void SpawnFood()
    {
        for(int i=-GM_mode3 .instance .maxBlock_3 /2;i<(GM_mode3 .instance .maxBlock_3 +1)/2;i++)
        {
            float dy = GM_mode3.instance.disBetweenBlock * i * 2;
            float dx = 0;
            if(snakemanager_mode3 .instance .snakeHead_3 )
            {
                dx = snakemanager_mode3.instance.snakeHeadPosX + GM_mode3.instance.disBetweenFoodAndSnake;
            }
            Vector3 newPos_3 = new Vector3(dx, dy, 0);
            if(Random .Range (1,100)>rate_3 )
            {
                Instantiate(foodPreFab_3, newPos_3, Quaternion.identity); 
            }
        }
    }
    
    void Update()
    {
        
    }
}
