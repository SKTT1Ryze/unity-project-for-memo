using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadHitObstacles_4 : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(transform ==snakemanager_4 .instance .snakeHead_4 )
        {
            if(col.tag =="blue"||col .tag =="red"||col.tag =="yellow"||col .tag =="green")
            {
                if(snakemanager_4 .instance .snakeColor_4 ==snakemanager_4.snakeColor.blue&& col.tag == "blue") { ScoreManager_4.instance.UpdateScorePoint(10); }
                else if(snakemanager_4.instance.snakeColor_4 == snakemanager_4.snakeColor.red  && col.tag == "red") { ScoreManager_4.instance.UpdateScorePoint(10); }
                else if(snakemanager_4.instance.snakeColor_4 == snakemanager_4.snakeColor.yellow  && col.tag == "yellow") { ScoreManager_4.instance.UpdateScorePoint(10); }
                else if(snakemanager_4.instance.snakeColor_4 == snakemanager_4.snakeColor.green && col.tag == "green") { ScoreManager_4.instance.UpdateScorePoint(10); }
                else { Debug.Log("GameOver"); }
                
            }
        }
    }
}
