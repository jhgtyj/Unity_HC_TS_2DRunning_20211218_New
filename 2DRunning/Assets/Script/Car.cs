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
        // ��J���� KeyCode
        Public KeyCode key;
        Public KeyCode jump = KeyCode.Space;
        Public KeyCode forward = KeyCode.w;
        Public KeyCode weapon1 = KeyCode.Alpha1;   //����Ʀr 

        Public KeyCode mouseL = KeyCode.Mouse0;   //�ƹ�����
        Public KeyCode mouseR = KeyCode.Mouse1;   //�ƹ��k��

        //�C������ (Hierearchy ���զ�u���ϥ�)�B�w�s�� Prefab (�ŦⲰ�l)
        Public GmaeObject goCamera;
        Public GmaeObject goBanana;
    }
}
