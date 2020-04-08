﻿using UnityEngine;         //引用Unity API(涵式庫：Unity 屬性、功能...)

// 類別 class定義一個物件
// 語法：class類別名稱
// ：MonoBehaviour 可以將此腳本掛在 Unity 物件上
// 類別必須放在物件上才會ˇ
public class Class1 : MonoBehaviour
{
    // 定義類別成員
    // C #
    // 1. 大小不一樣
    // 2. 括號成對出現 () [] {} '' "" 

    //事件：在特定時間會已指定次數執行的方法 (名稱是藍色)
    //開始事件：播放遊戲時執行一次 - 初始設定
    private void Start()
    {
        // 輸出("文字訊息");
        // C# 結尾為分號 ;
        print("哈囉，沃德~");
    }
}
