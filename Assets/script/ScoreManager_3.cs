using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager_3 : MonoBehaviour
{
    public static ScoreManager_3 instance;
    [Header("分数的Text")]
    public TextMesh ScoreText_3;
    //分数
    private int Score_3;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        Score_3 = 0;
        //获得分数的Text
        ScoreText_3 = GetComponentInChildren<TextMesh>();
        ScoreText_3.text = Score_3.ToString();
    }

    
    void Update()
    {
        
    }
    public void UpdateScore(int amount)
    {
        Score_3 += amount;
        ScoreText_3.text = Score_3.ToString();
    }
}
