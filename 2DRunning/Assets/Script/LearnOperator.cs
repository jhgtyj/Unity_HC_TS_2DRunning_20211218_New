using UnityEngine;


public class LearnOperator : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        #region �B��l : �ƾ�
        // �[ +
        print("�[�k : " + (a + b)); // 13
        // �� - 
        print("��k : " + (a - b)); // /
        // �� *
        print("���k : " + (a * b)); // 30
        // �� /
        print("���k : " + (a / b)); // 3.333
        // �l %
        print("�l�k : " + (a % b)); // 1
        #endregion


        �B��l : ���

        #region �B��l : �޿�
        // ����᪺���G�����L�� :  Lrue�Bfalse
        // �s��B��l�O�w�塞�L�����B��
        // �åB && (shift + 7)
        // �u�n�@�ӥ��L���� false ���G�N�O faise
        print(true && true);   // true
        print(true && false);  // false
        print(false && true);  // false
        print(false && false); // false
        // �Ϊ� || (shift + �Y)
        // �u�n�䤤�@�ӥ��L���� true ���G�N�O true
        print(true || true);  // true
        print(true || false); // true
        print(false || true); // true
        print(false || false); //false
        // �A��
        // �N���L���ܬۤ�
        print(!true); // false
        print(!false); // true
        �B��l : �޿�    
    }

    
   
}
