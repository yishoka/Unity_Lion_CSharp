using UnityEngine;         //引用Unity API(涵式庫：Unity 屬性、功能...)

// 類別 class定義一個物件
// 語法：class類別名稱
// ：MonoBehaviour 可以將此腳本掛在 Unity 物件上
// 類別必須放在物件上才會ˇ
public class Class1 : MonoBehaviour
{
    // 定義類別成員
    // C #
    // 1. 大小不一樣
    // 2. 括號成對出現 () [] {} '' "" < >

    [Header("汽車 1 號")]
    public Car car1;
    [Header("汽車 2 號")]
    public Car car2;

    //事件：在特定時間會已指定次數執行的方法 (名稱是藍色)
    //開始事件：播放遊戲時執行一次 - 初始設定
    private void Start()
    {
        // 輸出("文字訊息");
        // C# 結尾為分號 ;
        print("哈囉，沃德~");

        // 取得 get
        print("汽車 1 號的 CC數：" + car1.cc);
        print("汽車 2 號的品牌：" + car2.brand);

        // 設定 set
        car1.cc = 9999;
        car1.weight = 999.9f;
        car1.brand = "TOYOTA";
        car1.brake = true;
    }
}
