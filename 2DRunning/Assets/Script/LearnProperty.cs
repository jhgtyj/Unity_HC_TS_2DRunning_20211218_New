using UnityEngine;

/// <summary>
///  學習屬性 Property
/// </summary>
public class LearnProperty : MonoBehaviour
{
    // *屬性語法
    // 修飾詞 資料類型 屬性名稱
    // 快速完成 prop + TAB * 2
    // get 取得
    // set 存放
    public int lv { get; set; }

    public string passwordFieid;

    // c# 最新 10 版
    // Unity 預設 7 版
    // 唯獨屬性
    // 唯獨給予值的語法 : get => 值 ;
    // => 黏巴達 Lambda
    public string passwordProperty { get => "777"; }

    private void Start()
    {
        // 存放屬性 set
        lv = 100;
        // 取得屬性 get
        print("等級 : " + lv);

        // 存取欄位
        passwordFieid = "1234567";
        print("取得屬性密碼:" + passwordFieid);

        // 存取屬性
        // passwordProperty = "1234567";       // 唯獨屬性不能指定值
        print("取得屬性密碼:" + passwordProperty);
    }
}
