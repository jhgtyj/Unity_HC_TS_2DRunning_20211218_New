using UnityEngine;

/// <summary>
/// �ǲ߱���(�P�_��)
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
        // if �y�k
        // if (���L��) { �{���϶� �B �t��k �B ���z��}
        // �ֳt���� if + Tab * 2

        // ���L�� ���� true �|���� {} �����{��
        // ���L�� ���� false ������
        // ���� : �ϥ� true �P false �t��
        if (true)
        {
            print("�ڬO�P�_�� if");
        }

        // else if �����g�b if �U��A�ƶq�S������
        // else if (���L��) {�{���϶��B�t��k�B���z��}

        // �p�G�s�� ���� 10 �����O�N�W�[ 10
        if (combo == 100)
        {
            print("�����[ 10");
        }
        // �p�G�s�� ���� 100 �����O�N�W�[ 100
        else if (combo == 100)
        {
            print("�����[ 100");
        }
        // �p�G�s�� ���� 500 �����O�N�W�[ 500
        else if(combo == 500)
        {
            print("�����[ 500");
        }
    }
    private void start()
    {
       // switch �y�k
       // switch (�P�_�����)
       // {
       //     case ��1:
       //         �{�����e;
       //         �{�����e;
       //         �{�����e;
       //         �_�};
       //    case ��2:
       //        �{�����e;
       //        �{�����e;
    }
}
