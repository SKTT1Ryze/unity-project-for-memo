using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 0.5f;
    private bool Ismove = true;
    private Vector3 pos;
    private float dist;
    private Vector3 screenpos;

    void Start()
    {
        
    }

    void Update()
    {
        if(Ismove)
        {
           
            /*pos.x =Input .mousePosition .x -Screen .width *0.5f;
            pos.y = Input.mousePosition.y - Screen.height*0.5f;
            pos.z = transform.position.z;*/
            pos = Input.mousePosition;
            screenpos = Camera.main.WorldToScreenPoint(transform.position);
            //Debug.Log("pos:"+pos);
            //Debug.Log("this:"+screenpos );
            dist = Vector3.Distance(pos, screenpos );
            //Debug.Log("distance:"+dist);
            //Debug.Log("movevector:" + (pos - screenpos));
            if(dist >10f)
            {
                this.transform.Translate((pos - screenpos ) * Time.deltaTime * speed, Space.World);

            }
        }
    }
}
