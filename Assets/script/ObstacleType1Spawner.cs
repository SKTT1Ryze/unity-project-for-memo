using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleType1Spawner : MonoBehaviour
{
    [Header("障碍物预制件List")]
    public List<GameObject> ObstacleList;
    [Header("蛇头与障碍物之间的距离")]
    public float disBetweenObstacleAndHead = 55f;
    [Header("两个障碍物之间的距离")]
    public float disBetweenObstacles = 50f;
    private float snakePreviousPos_4;
    
    void Start()
    {
        snakePreviousPos_4 = snakemanager_4.instance.snakeHeadPoX_4;
    }

    
    void Update()
    {
            if (snakemanager_4.instance.snakeHead_4)
            {
                if (snakemanager_4.instance.snakeHeadPoX_4 - snakePreviousPos_4 > disBetweenObstacles)
                {
                    snakePreviousPos_4 = snakemanager_4.instance.snakeHeadPoX_4;
                    SpawnObstacle_1();
                }
            }
        
        
    }
    void SpawnObstacle_1()
    {
        
        
            GameObject obstacle = Instantiate(ObstacleList[Random.Range(0, ObstacleList.Count - 1)], snakemanager_4.instance.snakeHead_4.position + new Vector3(disBetweenObstacleAndHead, -snakemanager_4.instance.snakeHead_4.position.y, 0), Quaternion.identity);
        
            

    }
}
