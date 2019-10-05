using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movedown_mode2 : MonoBehaviour
{
    [Header("敌人移动的速度")]
    public float monsterspeed;
    [Header("敌人移动的范围")]
    public float moverange;
    private float rotateSpeed=2f;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position += Vector3.up * monsterspeed * Time.deltaTime;
        //超出范围
        if (transform.position.y < 2f || transform.position.y > moverange )
        {
            //反向
            monsterspeed = -monsterspeed;
            
        }
        //旋转
        Quaternion targetAngels;
        if (monsterspeed > 0)
        {
            targetAngels = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 0f);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetAngels, rotateSpeed);
            if (Quaternion.Angle(targetAngels, transform.rotation) < 1)

            {

                transform.rotation = targetAngels;

            }
        }
        if (monsterspeed < 0)
        {
            targetAngels = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 180f);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetAngels, rotateSpeed);
            if (Quaternion.Angle(targetAngels, transform.rotation) < 1)

            {

                transform.rotation = targetAngels;

            }
        }
    }
}
