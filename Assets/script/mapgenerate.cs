using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapgenerate : MonoBehaviour
{
    public GameObject floor;
    public Sprite[] floorsp;
    public float sizeofmap;

    void Start()
    {
        sizeofmap = 4f;
        for (int i=-6 ;i<6 ;i++)
        {
            for(int j=-6;j<6 ;j++)
            {
                GameObject floor0 = (GameObject)Instantiate(floor, new Vector3(sizeofmap  * i, sizeofmap  * j, 0), Quaternion.identity);
                floor.GetComponent<SpriteRenderer>().sprite = floorsp[Random.Range(0, floorsp.Length)];
            }
        }
    }

    void Update()
    {
        
    }
}
