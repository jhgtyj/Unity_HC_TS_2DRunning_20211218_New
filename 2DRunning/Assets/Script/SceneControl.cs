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
    /// ���J����
    /// </summary>
    private void LoadScene()
    {
        SceneManager.LoadScene("���d 1");
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
