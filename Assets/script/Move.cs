using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 0.5f;
    private bool Ismove = true;
    private Vector3 pos;
    private float dist;

    void Start()
    {
        
    }

    void Update()
    {
        if(Ismove)
        {
            /*Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();*/
            pos.x =Input .mousePosition .x -Screen .width *0.5f;
            pos.y = Input.mousePosition.y - Screen.height*0.5f;
            pos.z = transform.position.z;
            //Debug.Log("pos:"+pos);
            //Debug.Log("this:"+transform.position);
            dist = Vector3.Distance(pos, transform.position);
            //Debug.Log("distance:"+dist);
            //Debug.Log("movevector:" + (pos - transform.position));
            if(dist >10f)
            {
                this.transform.Translate((pos - transform.position) * Time.deltaTime * speed, Space.World);

            }
        }
    }
}
