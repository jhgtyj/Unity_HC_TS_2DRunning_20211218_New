using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// ��������
/// 1. �i�H��������
/// 2. �i�H���}�C��
/// </summary>
public class SceneControl : MonoBehaviour
{
    /// <summary>
    /// ������J����
    /// </summary>
    public void DelayLoadScene()
    {
        // �ϥ�MonoBehaviour �� PAI �y�k :
        // ��k�W��(�����޼�);
        Invoke("LoadScene", 1.5f);  // ����I�s("��k�W��" �A ������) - ����1.5��I�s LoadScene
    }
    /// <summary>
    /// ���J����
    /// </summary>
    private void LoadScene()
    {
        SceneManager.LoadScene("���d 1");
    }
    /// <summary>
    /// �������}�C��
    /// </summary>
    public void DelayQuitGame()
    {
        Invoke("QuitGame", 1.5f);
    }

    // Unity ���s�P�{�����q�覡
    // 1. ���}��k
    // 2.���s Button ���� On Click �i�H���w����k
    /// <summary>
    /// ���}�C��
    /// </summary>
    public void QuitGame()
    {
        print("���}�C��");
        Application.Quit();        // ���ε{��.���}() - �����C���AUnity �����|����
    }
}
