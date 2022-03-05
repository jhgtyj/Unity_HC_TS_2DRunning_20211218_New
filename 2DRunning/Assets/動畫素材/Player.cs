using UnityEngine;

/// <summary>
///  ��V���b���a����]�w�t��
/// </summary>
public class Player : MonoBehaviour
{
    #region ���
    // �]�B�t�סB���D���סB�O�_�Ʀ�B�O�_���`
    // �ʵe�ѼƸ��D�B�Ʀ�P���`
    // Header ���D
    // Range �d�� : �ȭ���ƭȫ��A��ơAfloat�Bint
    // Tooltip ����
    [Header("�]�B�t��"), Range(0, 500)]
    public float speed = 1.5f;
    [Header("���D����"), Range(0, 5000)]
    public int jump = 500;
    [Tooltip("�x�s����O�_�b�Ʀ�")]
    public bool isSlide;
    [Tooltip("�x�s����O�_���`")]
    public bool isDead;

    public string parameterJump = "Ĳ�o���D";
    public string parameterSlide = "�}���Ʀ�";
    public string parameterDead = "Ĳ�o���`";

    [Header("���D�ץ�")]
    public KeyCode KeyJump = KeyCode.Space;

    // �s�� Transform �Ĥ@�ؤ覡
    // public Transform traPlayer;
    #endregion

    // �ݩʭ��O ... > Debug �Ҧ��i�H�ݨ�p�H���
    private Rigidbody2D rig;

    [Header("���D�q�Ƴ̤j��"), Range(0, 5)]
    public int countJumpMax = 2;

    public int countJump;

    #region �ƥ�
    private void Update()
    {
        // GetComponent<��������>() - <> �x�� �A �Ҧ�����
        // ���o���w����
        rig = GetComponent<Rigidbody2D>();
    }
    public Transform traPlayer;
    #endregion

    #region ��k
    /// <summary>
    /// �]�B
    /// </summary>
    private void Run()
    {
        // �s��  Transform �Ĥ@�ؤ覡
        // ���a�ܧ�.�첾(x �A y �A z)
        // Time.deltaTime �@�V ���ɶ�
        // traPlayer.Translate(speed * Time.deltaTime, 0 , 0);

        // �s��  Transform �ĤG�ؤ覡
        // 1. ��n��� Transform �P������P�@���h
        // �y�k :
        // Transform.�����W��
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    /// <summary>
    /// ���D
    /// </summary>
    private void Jump()
    {
        bool inputJump = Input.GetKeyDown(KeyJump);
        // print("�O�_���U���D : " + inputJump);
        if (inputJump)
        {
            // print("���D");
            // ����.�K�[���O(�G���V�q)
            rig.AddForce(new Vector2(0, jump));
        }
    }
    #endregion
}

