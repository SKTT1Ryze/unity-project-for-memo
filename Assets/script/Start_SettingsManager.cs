using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Start_SettingsManager : MonoBehaviour
{
    public Toggle EasyTogger;
    public Toggle MiddleTogger;
    public Toggle HardTogger;
    public Toggle YinYueTogger;
    public Toggle YinXiaoTogger;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void EnterSelectSkinScene()
    {
        Debug.Log("进入皮肤设置");
    }
    public void ReturnStartScene()
    {
        Debug.Log("返回开始界面");
    }
    public void YinYueOn()
    {
        if(YinYueTogger .isOn ==true )
        {
            Debug.Log("音乐开启");
        }
        if (YinYueTogger.isOn == false )
        {
            Debug.Log("音乐关闭");
        }

    }
    public void YinXiaoOn()
    {

        if (YinXiaoTogger.isOn == true)
        {
            Debug.Log("音效开启");
        }
        if (YinXiaoTogger.isOn == false )
        {
            Debug.Log("音效关闭");
        }
    }
    public void EasySelect()
    {
        if (EasyTogger.isOn == true)
            Debug.Log("难度为低");
    }
    public void MiddleSelect()
    {
        if (MiddleTogger.isOn == true)
            Debug.Log("难度为中");
    }
    public void HardSelect()
    {
        if (HardTogger.isOn == true)
            Debug.Log("难度为高");
    }
    public void ReTurnMainMenu()
    {
        Debug.Log("返回主菜单");
    }
    public void ReTurnGame()
    {
        Debug.Log("返回游戏");
    }
}
