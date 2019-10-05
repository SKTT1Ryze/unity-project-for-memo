using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gateSpawner_4 : MonoBehaviour
{
    [Header("颜色门预制件List")]
    public List<GameObject> gatePrefabsList_4;
    
    [Header ("蛇头与颜色门之间的距离")]
    public  float disBetweenGateAndHead = 50f;
    [Header ("两个颜色门之间的距离")]
    public  float disBetweenGates=50f;
    private float snakePreviousPos_4;
    void Start()
    {
        snakePreviousPos_4 = snakemanager_4.instance.snakeHeadPoX_4;
    }

    
    void Update()
    {
        if(snakemanager_4 .instance .snakeHead_4 )
        {
            if (snakemanager_4 .instance.snakeHeadPoX_4  - snakePreviousPos_4 > disBetweenGates )
            {
                SpawnGate_4();
                snakePreviousPos_4 = snakemanager_4.instance.snakeHeadPoX_4;
            }
        }
    }
    void SpawnGate_4()
    {
        GameObject gate= Instantiate(gatePrefabsList_4 [Random .Range (0,gatePrefabsList_4 .Count -1)], snakemanager_4 .instance .snakeHead_4 .position +new Vector3 (disBetweenGateAndHead , -snakemanager_4.instance.snakeHead_4.position.y , 0) , Quaternion.identity);
    }
}
