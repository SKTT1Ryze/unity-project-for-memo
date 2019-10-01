using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 0.5f;
    private bool Ismove = true;
    private Vector3 pos;

    void Start()
    {
        
    }

    void Update()
    {
        if(Ismove)
        {
            /*Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();*/
            pos = Input.mousePosition;
            Debug.Log(pos);


        }
    }
}
