using UnityEngine;

/// <summary>
/// �ǲ��R�A API
/// �R�A Static
/// �D���骫��A���s�b�C��������������
/// ���Ǫ��T���R�A API �ϥΤ覡
/// 1. ���o�R�A�ݩ�
/// 2. �s���R�A�ݩ�
/// 3. �ϥ��R�A��k
/// </summary>
public class LearnAPIStatic : MonoBehaviour
{
    private void Start()
    {
        // �R�A�ݩʻy�k
        // 1. ���o Get
        // ���O�W��.�R�A�ݩʦW��
        print("��P�v : " + Mathf.PI);
        print("�L���j : " + Mathf.Infinity);

        // 2. �s��
        // ���O�W��.�R�A�ݩʦW�� ���w ��;
        // Mathf PI = 9.87654321f;           // �߿W�ݩʤ���s��
        Cursor.visible = false;              // ���÷ƹ�

        // �R�A��k�y�k
        // 3. �ϥ�
        // ���O�W��.�R�A��k�W��(�������޼�);
        float number777 = Mathf.Abs(-77.7f);
        print("-77.7 ���M���:" + number777);
    }
    private void start()
    {
        #region �m�߰�
        print("�Ҧ���v���ƶq : " + Camera.allCamerasCount);
        print("2D ���O : " + Physics2D.gravity);

        Physics2D.gravity = new Vector2(0, -20);
        print("2D ���O : " + Physics2D.gravity);
        Time.timeScale = 0.5f;

        float number9999 = Mathf.Ceil(9.999f);
        print("9.999 �L����i�� : " + number9999);
        Vector3 a = Vector3.one;
        Vector3 b = Vector3.one * 22;
        float dis = Vector3.Distance(a, b);
        print("a �P b ���Z�� : " + dis);

        Application.OpenURL("https://unity.com");
        #endregion
    }
    private void Update()
    {
        print("�O�_���U���N�� : <color-red>" + Input.anyKeyDown + "</color>");
        //print("�C���g�L�ɶ� : " + Time.time);

        print("���a�O�_���U�ť��� : <color=yellow>" + Input.GetKeyDown(KeyCode.Space) + "</color>");
    }
}