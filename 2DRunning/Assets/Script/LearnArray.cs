using UnityEngine;

/// <summary>
/// �ǲ߰}�C
/// </summary>
public class LearnArray : MonoBehaviour
{
    // �}�C�@��
    // �x�s�ۦP�������h�����

    // �ϥ�����x�s�h�����
    public int atk1 = 10;
    public int atk2 = 20;
    public int atk3 = 30;

    // �}�C�y�k
    // ������� []
    public int[] atks;

    // �}�C��l��
    // 1. ���w�}�C��Ƽƶq�����w��
    public float[] speeds = new float[5];
    // 2. ���w�}�C���
    public string[] props = { "����", "�Ť�", "����" };
    public Vector3[] positions = { new Vector3(0, 1, 2), new Vector3(2, 2, 2) };
    public bool[] complete = { true, true, true };

    private void Start()
    {
        // �s���}�C���
        // 1. �s���}�C���
        // �}�C�W��[�s��] = ��;
        // �N�}�C�Ĥ@����Ƨאּ 70
        atks[0] = 70;
        // 2. �ϥΰ}�C�|�J�쪺���~ : �W�X�}�C�d��
        // IndexOutOfRange - �s�����s�b
        // atks[3] = 99;

        // 3. ���o�}�C���
        // �}�C�W��[�s��]
        print("�ĤG���D���� : " + props[1]);
        print("�ĤG���y�и�� : " + positions[1]);

        //4. ���o�}�C�ƶq Length
        print("���L�Ȱ}�C���ƶq : " + complete.Length);
    }
}
