using UnityEngine;

/// <summary>
/// �ǲߤ�k
/// </summary>
public class LearnMethod : MonoBehaviour
{
    // *��k�y�k
    // ����k �Ǧ^������� ��k�W��() {�{�����e�B���z���B�t��k}
    // void �L�Ǧ^ : �ϥΤ�k�ɤ��|����ƶǦ^

    // �ۭq��k
    private void Start()
    {
        // �I�s�ۭq��k
        // �ۭq��k�W��();
        Test();
        Test();
        shootFire();
        shootIce();
        // ���X�ӰѼƴN�n��J�X�Ӥ޼�
        // ���w�]�Ȫ��Ѽƥi�H���ε��޼ơA�H�w�]�Ȭ��D
        shoot("���y", 170);
        shoot("�B�y", 80);
        shoot("�q�y", 300, "������");
    }

    // �ۭq��k : ���|�۰ʰ���A�����I�s ...
    private void Test() { }

    //�o�g�B�y
    private void shootFire()
    {
        print("�o�g���y");
        print("����t�� 100");
        print("�o�g����");
    }

    private void shootIce()
    {
        print("�o�g�B�y");
        print("����t�� 50");
        print("�o�g����");
    }

    // ���@�ʻP�X�R��
    // �Ѽƻy�k : �Ѽ�1���� �Ѽ�1�W��, �Ѽ�2���� �Ѽ�2�W��
    // �Ѽƹw�]�� : �Ѽ����� �ѼƦW�� = �w�]��
    // *���w�]�Ȫ��Ѽƥ�����b�᭱
    private void shoot(string type, int speed, string sound = "������")
    {
        print("<coior=yellow�o�g>" + type + "</color");
        print("<color=yellow>����t��" + speed + "</color>");
        print("<color=yeiiow>�o�g����" + sound + "</color>");
    }


}
