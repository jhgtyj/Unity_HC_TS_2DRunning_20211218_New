using UnityEngine;
using UnityEngine.UI;   // �ޥ� ���� API

/// <summary>
/// �C���޲z��
/// �����q�B�ɶ��P���ƺ޲z
/// </summary>

public class GameManagr : MonoBehaviour
{
    [Header("���")]
    public Image imgHp;
    [Header("�ɶ�")]
    public Text textTime;
    [Header("����")]
    public Text textScore;
    [Header("���a��q"), Range(0, 5000)]
    public float hp = 100;
    [Header("�D�����")]
    public string tagProp = "�D��";
    [Header("��������")]
    public string tagTrap = "����";
    [Header("�Y��|�ɦ媺�D��W��")]
    public string propEatToAddHp = "�ɦ�";
    [Header("�Y��ɦ�D���_��q"), Range(0, 50)]
    public float valueEatToAddHp = 10;
    [Header("�����e��")]
    public CanvasGroup groupFinal;
    [Header("�����e�����D")]
    public Text textFinalTitle;
    [Header("��ܵ����e�����j"), Range(0, 0.5f)]
    public float showFinalInterval = 0.1f;
    [Header("���`�ʵe�Ѽ�")]
    public string ParameterDead = "Ĳ�o���`";

    private int score;
    private float hpMax;
    private Animator ani;
    private Player Player;

    private void Start()
    {
        ani = GetComponent<Animator>();
        Player = GetComponent<Player>();
        hpMax = hp;                 // ��q�̤j�ȹC���}�l�ɫ��w����q��l��
    }

    private void Update()
    {
        UpdateTimeUI();
        UpdateHpUI();
    }

    /// <summary>
    /// ��ܵ����e��
    /// �C���W�[ 0.2
    /// </summary>
    private void ShowFinal()
    {
        groupFinal.alpha += 0.2f;
    }

    /// <summary>
    /// ��s�ɶ�����
    /// </summary>
    private void UpdateTimeUI()
    {
        // print("��e�����ɶ� : " + Time.timeSinceLevelLoad);
        // ToString() �N����ର�r������
        // () ���i�H�榡�Ʀr��AF�Ʀr : �p���I��X��A�Ҧp : F2 �p���I�����
        textTime.text = "�ɶ�"+Time.timeSinceLevelLoad.ToString("F2");
    }

    /// <summary> 
    /// ��s�������
    /// </summary>
    private void UpdateHpUI()
    {
        hp -= Time.deltaTime;
        hp = Mathf.Clamp(hp, 0, hpMax);
        imgHp.fillAmount = hp / hpMax;
        Lose();
    }

    /// <summary>
    /// �[���ƨåB��s����
    /// </summary>
    private void AddScoreAndUpdateUI(int add)
    {
        score +=add;
        textScore.text = "���� : " + score;
    }

    // �󴫦W�٧ֱ��� Ctrl + R R
    /// <summary>
    /// �ܧ��q�åB��s����
    /// </summary>
    /// <param name="value">�y���ˮ`</param>
    private void TakeDamageAndUpdateUI(float value)
    {
        hp += value;
        hp = Mathf.Clamp(hp, 0, hpMax);            // ��q = �ƾ�.����(��q�A�̤p�ȡA�̤j��) �N��q���b�̤p~�̤j���
        imgHp.fillAmount = hp / hpMax; 
        Lose();
    }

    /// <summary>
    /// �C������
    /// </summary>
    private void Lose()
    {
        if (hp == 0 && groupFinal.alpha == 0)   // �p�G ��q ���� 0 �åB �����e�� �z���� ���� 0
        {
            textFinalTitle.text = "�D�ԥ���";

            groupFinal.interactable = true;

            ani.SetTrigger(ParameterDead);
            Player.enabled = false;

            // ���𭫽ƩI�s("��k�W��"�A����ɶ��A���j)
            InvokeRrpeating("ShowFinal", 0, showFinalInterval);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // print("���a�I�쪺���� : " + collision.name);

        if (collision.tag == tagProp)
        {
            AddScoreAndUpdateUI(collision.GetComponent<Prop>().score);
            if (collision.name.Contains("���")) ChangHpAndUpdateUI(10);                                  
            Destroy(collision.gameObject);                                                // Destroy (����) �M������
        }

        if (collision.tag == tagTrap)
        {
            TakeDamageAndUpdateUI(collision.GetComponent<Trap>().damage);
        }
    }
}

