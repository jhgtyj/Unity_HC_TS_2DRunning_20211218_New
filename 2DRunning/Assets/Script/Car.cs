using UnityEngine; 

public class Car : MonoBehaviour
{
    // 輸入按鍵 KeyCode
    public KeyCode key;
    public KeyCode jump = KeyCode.Space;
    public KeyCode forward = KeyCode.W;
    public KeyCode weapon1 = KeyCode.Alpha1;   //左邊數字 

    public KeyCode mouseL = KeyCode.Mouse0;   //滑鼠左鍵
    public KeyCode mouseR = KeyCode.Mouse1;   //滑鼠右鍵

    //遊戲物件 (Hierearchy 內白色線條圖示)、預製物 Prefab (藍色盒子)
    public GameObject goCamera;
    public GameObject goBanana;
}
