using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 場景控制
/// 1. 可以切換場景
/// 2. 可以離開遊戲
/// </summary>
public class SceneControl : MonoBehaviour
{
    /// <summary>
    /// 延遲載入場景
    /// </summary>
    public void DelayLoadScene()
    {
        // 使用MonoBehaviour 的 PAI 語法 :
        // 方法名稱(對應引數);
        Invoke("LoadScene", 1.5f);  // 延遲呼叫("方法名稱" ， 延遲秒數) - 延遲1.5秒呼叫 LoadScene
    }
    /// <summary>
    /// 載入場景
    /// </summary>
    private void LoadScene()
    {
        SceneManager.LoadScene("關卡 1");
    }
    /// <summary>
    /// 延遲離開遊戲
    /// </summary>
    public void DelayQuitGame()
    {
        Invoke("QuitGame", 1.5f);
    }

    // Unity 按鈕與程式溝通方式
    // 1. 公開方法
    // 2.按鈕 Button 元件 On Click 可以指定此方法
    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void QuitGame()
    {
        print("離開遊戲");
        Application.Quit();        // 應用程式.離開() - 關閉遊戲，Unity 內不會執行
    }
}
