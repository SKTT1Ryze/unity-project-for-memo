using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontrol : MonoBehaviour
{
    public GameObject snake;
    public float smooth=10f;
    private Vector3 targetpos;

    private void Start()
    {
      
    }
    private void Update()
    {
        targetpos = snake.transform.position;
        targetpos.z = transform.position .z;
        //Debug.Log("targetpos" + targetpos);
        //Debug.Log("this" + transform.position);
        this.transform.position = Vector3.Lerp(transform.position, targetpos, smooth * Time.deltaTime);
    }
}
