using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDestroy_3 : MonoBehaviour
{
    [Header("Block生命值")]
    public int life_3;
    TextMesh textMesh;
    void Start()
    {
        life_3 = Random.Range(1, snakemanager_mode3.instance.bodyAmount_3 / 2 + 10);
        textMesh = GetComponentInChildren<TextMesh>();
        SetBlockColorAndText(0);
    }
    public void SetBlockColorAndText(int amount)
    {
        life_3 += amount;
        if (life_3 < 0)
            return;
        //颜色变化
        /*Color32 color = GetComponent<SpriteRenderer>().color;
        if (life_3 >=GM_mode3.instance.maxLife_3)
            color = new Color32(255, 0, 0, 255);
        else if (life_3 > GM_mode3.instance.maxLife_3 / 2)
            color = new Color32(255, (byte)(64 + Random.Range(128, 196)), 0, 255);
        else  
            color = new Color32(255, (byte)(64 + Random.Range(64, 128)), 0, 255);
        GetComponent<SpriteRenderer>().color = color;*/
        textMesh.text = life_3.ToString();

    }
   
    void Update()
    {
        if (snakemanager_mode3.instance.snakeHeadPosX - transform.position.x > 10)
            Destroy(gameObject);
    }


    private void OnCollisionEnter2D(Collision2D col)
    {
        //对蛇头碰撞的处理
        if (col.transform.tag == "Player")
        {
            //Debug.Log("life" + life_3);
            if (life_3 < 1)
                Destroy(gameObject);
        }
    }
}
