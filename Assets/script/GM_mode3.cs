using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM_mode3 : MonoBehaviour
{
    public static GM_mode3  instance;
    [Header ("贪吃蛇水平速度")]
    public float xspeed;
    [Header("贪吃蛇垂直速度")]
    public float yspeed;
    [Header ("一列最大方块数")]
    public int maxBlock_3=5;
    [Header ("蛇头与食物之间的最小距离")]
    public float disBetweenFoodAndSnake = 8;
    //Block的最大容许生命值和分数
    public int maxLife_3,score_3;
    public float disBetweenBlock
    {
        get
        {
            //return Camera.main.orthographicSize * Camera.main.aspect / maxBlock_3;
            return Camera.main.orthographicSize / maxBlock_3;
        }
    }
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateScore(int amount)
    {
        score_3 += amount;
    }
    public void GameOver()
    {
        Debug.Log("GameOver");
    }
}
