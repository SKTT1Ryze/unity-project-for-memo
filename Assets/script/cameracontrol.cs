using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontrol : MonoBehaviour
{
    //获得snakemanager脚本
    public snakemanager   snake;
    //获得snakemanager物体
    public GameObject    snakemanager;
    public float smooth=10f;
    

    private Vector3 targetpos;

    private void Start()
    {
        snake = snakemanager .GetComponent <snakemanager >() ; 
    }
    private void Update()
    {
        if(snake)
        {
            targetpos = snake.snakehead.position;
            targetpos.z = transform.position.z;
            //Debug.Log("targetpos" + targetpos);
            //Debug.Log("this" + transform.position);
            this.transform.position = Vector3.Lerp(transform.position, targetpos, smooth * Time.deltaTime);
        }
        
    }
}
