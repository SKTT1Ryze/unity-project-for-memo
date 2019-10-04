using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner_3 : MonoBehaviour
{
    [Header("Block的预制件")]
    public GameObject blockPrefab_3;
    [Header("Block的产生时间范围")]
    public float minSpawnTime, maxSpawnTime;
    [Header("一列Block与蛇头之间的距离")]
    public float disBetweenBlock_3;
    float randomTime_3;
    float tick_3;
    float snakePreviousPos;
    public List<Sprite > BlockSpriteList_mode3 = new List<Sprite >();

    void Start()
    {
        randomTime_3 = Random.Range(minSpawnTime, maxSpawnTime);
    }

    
    void Update()
    {
        if(tick_3 <randomTime_3 )
        {
            tick_3 += Time.deltaTime;
        }
        else
        {
            tick_3 = 0;
            randomTime_3 = Random.Range(minSpawnTime, maxSpawnTime);
            //SpawnBlock();
        }
        if(snakemanager_mode3 .instance .snakeHead_3 )
        {
            if(snakemanager_mode3 .instance.snakeHeadPosX -snakePreviousPos >disBetweenBlock_3 +GM_mode3 .instance .disBetweenBlock *2)
            {
                SpawnOneLineBlocks();
                snakePreviousPos = snakemanager_mode3.instance.snakeHeadPosX;
            }
        }
    }
    void SpawnOneLineBlocks()
    {
        for(int i=-GM_mode3 .instance .maxBlock_3 /2;i<(GM_mode3 .instance .maxBlock_3 +1)/2;i++)
        {
            float dy = GM_mode3.instance.disBetweenBlock * i * 2;
            float dx = 0;
            if(snakemanager_mode3 .instance .snakeHead_3 )
            {
                dx = snakemanager_mode3.instance.snakeHeadPosX + disBetweenBlock_3 * GM_mode3.instance.disBetweenBlock*2;
            }
            Vector3 newPos = new Vector3(dx, dy, 0);
            GameObject g = Instantiate(blockPrefab_3, newPos, Quaternion.identity);
            g.GetComponentInChildren <SpriteRenderer >().sprite  =BlockSpriteList_mode3[Random.Range(0, BlockSpriteList_mode3.Count-1)];
        }
    }


}
