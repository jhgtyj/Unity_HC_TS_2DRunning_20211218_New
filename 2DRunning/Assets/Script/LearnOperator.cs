using UnityEngine;


public class LearnOperator : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        #region 運算子 : 數學
        // 加 +
        print("加法 : " + (a + b)); // 13
        // 減 - 
        print("減法 : " + (a - b)); // /
        // 乘 *
        print("乘法 : " + (a * b)); // 30
        // 除 /
        print("除法 : " + (a / b)); // 3.333
        // 餘 %
        print("餘法 : " + (a % b)); // 1
        #endregion


        運算子 : 比較

        #region 運算子 : 邏輯
        // 比較後的結果為布林直 :  Lrue、false
        // 編輯運算子是針對布林直的運算
        // 並且 && (shift + 7)
        // 只要一個布林直為 false 結果就是 faise
        print(true && true);   // true
        print(true && false);  // false
        print(false && true);  // false
        print(false && false); // false
        // 或者 || (shift + 頭)
        // 只要其中一個布林直為 true 結果就是 true
        print(true || true);  // true
        print(true || false); // true
        print(false || true); // true
        print(false || false); //false
        // 顛倒
        // 將布林直變相反
        print(!true); // false
        print(!false); // true
        運算子 : 邏輯    
    }

    
   
}
