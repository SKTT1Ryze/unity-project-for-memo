using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHelpSceneManager : MonoBehaviour
{
    [Header("获得四张图片")]
    public List<Transform> HelpPictureList;
    [Header("获得按钮")]
    public Transform Help_Button;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void snakeColor_Help()
    {
        Debug.Log("显示征服色彩介绍");
        Help_Button.SetSiblingIndex(-1);
        HelpPictureList[0].SetSiblingIndex(0);
        HelpPictureList[1].SetSiblingIndex(1);
        HelpPictureList[2].SetSiblingIndex(2);
        HelpPictureList[3].SetSiblingIndex(3);
    }
    public void snakeDiamonds_Help()
    {
        Debug.Log("显示无尽方块介绍");
        Help_Button.SetSiblingIndex(-1);
        HelpPictureList[0].SetSiblingIndex(0);
        HelpPictureList[1].SetSiblingIndex(1);
        HelpPictureList[2].SetSiblingIndex(3);
        HelpPictureList[3].SetSiblingIndex(2);
    }
    public void snakeRisk_Help()
    {
        Debug.Log("显示小蛇冒险介绍");
        Help_Button.SetSiblingIndex(-1);
        HelpPictureList[0].SetSiblingIndex(3);
        HelpPictureList[1].SetSiblingIndex(0);
        HelpPictureList[2].SetSiblingIndex(1);
        HelpPictureList[3].SetSiblingIndex(2);
    }
    public void snakeStorm_Help()
    {
        Debug.Log("显示小蛇闯关介绍");
        Help_Button.SetSiblingIndex(-1);
        HelpPictureList[0].SetSiblingIndex(0);
        HelpPictureList[1].SetSiblingIndex(3);
        HelpPictureList[2].SetSiblingIndex(1);
        HelpPictureList[3].SetSiblingIndex(2);
    }
    public void aboutUs_Help()
    {
        Debug.Log("关于我们");

    }
    public void exit_Help()
    {
        Debug.Log("返回");
    }
}
