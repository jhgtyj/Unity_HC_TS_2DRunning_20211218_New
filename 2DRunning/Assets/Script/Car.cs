using JetBrains.Annotations;
using UnityEngine; 



public class Car : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 輸入按鍵 KeyCode
        Public KeyCode key;
        Public KeyCode jump = KeyCode.Space;
        Public KeyCode forward = KeyCode.w;
        Public KeyCode weapon1 = KeyCode.Alpha1;   //左邊數字 

        Public KeyCode mouseL = KeyCode.Mouse0;   //滑鼠左鍵
        Public KeyCode mouseR = KeyCode.Mouse1;   //滑鼠右鍵

        //遊戲物件 (Hierearchy 內白色線條圖示)、預製物 Prefab (藍色盒子)
        Public GmaeObject goCamera;
        Public GmaeObject goBanana;
    }
}
