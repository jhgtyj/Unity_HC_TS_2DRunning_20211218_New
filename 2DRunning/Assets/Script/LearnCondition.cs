using UnityEngine;

/// <summary>
/// 學習條件式(判斷式)
/// 1. if
/// 2. switch
/// </summary>
public class LearnCondition : MonoBehaviour
{
    public bool haskey = true;
    public int combo = 0;
    public string weapon;

    private void Start()
    {
        // if 語法
        // if (布林值) { 程式區塊 、 演算法 、 陳述式}
        // 快速完成 if + Tab * 2

        // 布林值 等於 true 會執行 {} 內的程式
        // 布林值 等於 false 不執行
        // 實驗 : 使用 true 與 false 差異
        if (true)
        {
            print("我是判斷式 if");
        }

        // else if 必須寫在 if 下方，數量沒有限制
        // else if (布林值) {程式區塊、演算法、陳述式}

        // 如果連擊 等於 10 攻擊力就增加 10
        if (combo == 100)
        {
            print("攻擊加 10");
        }
        // 如果連擊 等於 100 攻擊力就增加 100
        else if (combo == 100)
        {
            print("攻擊加 100");
        }
        // 如果連擊 等於 500 攻擊力就增加 500
        else if(combo == 500)
        {
            print("攻擊加 500");
        }
    }
    private void start()
    {
       // switch 語法
       // switch (判斷的資料)
       // {
       //     case 值1:
       //         程式內容;
       //         程式內容;
       //         程式內容;
       //         斷開;
       //    case 值2:
       //        程式內容;
       //        程式內容;
    }
}
