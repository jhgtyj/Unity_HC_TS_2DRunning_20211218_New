using UnityEngine;

/// <summary>
/// �j��
/// 1. while  *
/// 2. do while
/// 3. for
/// 4. foreach
/// </summary>
public class LearnLoop : MonoBehaviour
{
    // �j��@��
    // �B�z���Ƶ{��

    public int[] scores = new int[20];

    private void Start()
    {
        // �j��P�}�C����
        for (int i = 0; i < scores.Length; i++)


            // ��X�������o
            print("���o");
        print("���o");
        print("���o");
        print("���o");
        print("���o");

        // while�j��y�k
        // �P if �P�_�O�����ۤ�
        // if (���L��) {�{���϶�}
        // while (���L��) {�{���϶�}

        // ���L�Ȭ� true �������{}
        /*
        while (true)
        {
        print("�j�� while");
        }
    }*/

        int count = 0;
        while (count < 5)
        {
            print("���o");
            count++;
        }

        // for (��l�� �F ���L�� �F �j�鵲���|���檺�{��)
        for (int i = 0; i < 5; i++)
        {
            print("���o");
        }

        // ��X�Ʀr 1 ~ 100
        for (int i = 1; i < 101; i++)
        {
            print("��X�Ʀr : " + i);
        }
    }
}
