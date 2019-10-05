using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager_4 : MonoBehaviour
{
    public static ScoreManager_4 instance;
    [Header("分数的Text")]
    public TextMesh scoreText;
    private  int scorePoint_4;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        scorePoint_4 = 0;
        scoreText = this.GetComponentInChildren<TextMesh>();
        if(scoreText )
        {
            scoreText.text = scorePoint_4.ToString();
        }
    }

    
    void Update()
    {
        
    }
    public void UpdateScorePoint(int amount)
    {
        scorePoint_4 += amount;
        if (scoreText)
        {
            scoreText.text = scorePoint_4.ToString();
        }
    }
}
