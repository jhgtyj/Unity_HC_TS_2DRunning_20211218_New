using UnityEngine; 

public class Car : MonoBehaviour
{
    // ��J���� KeyCode
    public KeyCode key;
    public KeyCode jump = KeyCode.Space;
    public KeyCode forward = KeyCode.W;
    public KeyCode weapon1 = KeyCode.Alpha1;   //����Ʀr 

    public KeyCode mouseL = KeyCode.Mouse0;   //�ƹ�����
    public KeyCode mouseR = KeyCode.Mouse1;   //�ƹ��k��

    //�C������ (Hierearchy ���զ�u���ϥ�)�B�w�s�� Prefab (�ŦⲰ�l)
    public GameObject goCamera;
    public GameObject goBanana;
}
