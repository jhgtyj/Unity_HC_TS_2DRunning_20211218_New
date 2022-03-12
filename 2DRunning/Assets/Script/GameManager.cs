using UnityEngine;
using UnityEngine.UI;   // 引用 介面 API

/// <summary>
/// 遊戲管理器
/// 角色血量、時間與分數管理
/// </summary>

public class GameManagr : MonoBehaviour
{
    [Header("血條")]
    public Image imgHp;
    [Header("時間")]
    public Text textTime;
    [Header("分數")]
    public Text textScore;
    [Header("玩家血量"), Range(0, 5000)]
    public float hp = 100;
    [Header("道具標籤")]
    public string tagProp = "道具";
    [Header("陷阱標籤")]
    public string tagTrap = "陷阱";
    [Header("吃到會補血的道具名稱")]
    public string propEatToAddHp = "補血";
    [Header("吃到補血道具恢復血量"), Range(0, 50)]
    public float valueEatToAddHp = 10;
    [Header("結束畫面")]
    public CanvasGroup groupFinal;
    [Header("結束畫面標題")]
    public Text textFinalTitle;
    [Header("顯示結束畫面間隔"), Range(0, 0.5f)]
    public float showFinalInterval = 0.1f;
    [Header("死亡動畫參數")]
    public string ParameterDead = "觸發死亡";

    private int score;
    private float hpMax;
    private Animator ani;
    private Player Player;

    private void Start()
    {
        ani = GetComponent<Animator>();
        Player = GetComponent<Player>();
        hpMax = hp;                 // 血量最大值遊戲開始時指定成血量初始值
    }

    private void Update()
    {
        UpdateTimeUI();
        UpdateHpUI();
    }

    /// <summary>
    /// 顯示結束畫面
    /// 每次增加 0.2
    /// </summary>
    private void ShowFinal()
    {
        groupFinal.alpha += 0.2f;
    }

    /// <summary>
    /// 更新時間介面
    /// </summary>
    private void UpdateTimeUI()
    {
        // print("當前場景時間 : " + Time.timeSinceLevelLoad);
        // ToString() 將資料轉為字串類型
        // () 內可以格式化字串，F數字 : 小數點後幾位，例如 : F2 小數點後兩位數
        textTime.text = "時間"+Time.timeSinceLevelLoad.ToString("F2");
    }

    /// <summary> 
    /// 更新血條介面
    /// </summary>
    private void UpdateHpUI()
    {
        hp -= Time.deltaTime;
        hp = Mathf.Clamp(hp, 0, hpMax);
        imgHp.fillAmount = hp / hpMax;
        Lose();
    }

    /// <summary>
    /// 加分數並且更新介面
    /// </summary>
    private void AddScoreAndUpdateUI(int add)
    {
        score +=add;
        textScore.text = "分數 : " + score;
    }

    // 更換名稱快捷鍵 Ctrl + R R
    /// <summary>
    /// 變更血量並且更新介面
    /// </summary>
    /// <param name="value">造成傷害</param>
    private void TakeDamageAndUpdateUI(float value)
    {
        hp += value;
        hp = Mathf.Clamp(hp, 0, hpMax);            // 血量 = 數學.夾住(血量，最小值，最大值) 將血量夾在最小~最大放圍內
        imgHp.fillAmount = hp / hpMax; 
        Lose();
    }

    /// <summary>
    /// 遊戲失敗
    /// </summary>
    private void Lose()
    {
        if (hp == 0 && groupFinal.alpha == 0)   // 如果 血量 等於 0 並且 結束畫面 透明度 等於 0
        {
            textFinalTitle.text = "挑戰失敗";

            groupFinal.interactable = true;

            ani.SetTrigger(ParameterDead);
            Player.enabled = false;

            // 延遲重複呼叫("方法名稱"，延遲時間，間隔)
            InvokeRrpeating("ShowFinal", 0, showFinalInterval);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // print("玩家碰到的物件 : " + collision.name);

        if (collision.tag == tagProp)
        {
            AddScoreAndUpdateUI(collision.GetComponent<Prop>().score);
            if (collision.name.Contains("草莓")) ChangHpAndUpdateUI(10);                                  
            Destroy(collision.gameObject);                                                // Destroy (物件) 撤除物件
        }

        if (collision.tag == tagTrap)
        {
            TakeDamageAndUpdateUI(collision.GetComponent<Trap>().damage);
        }
    }
}

