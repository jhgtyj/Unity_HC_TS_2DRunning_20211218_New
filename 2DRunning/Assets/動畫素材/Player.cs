using UnityEngine;

/// <summary>
///  橫向卷軸玩家控制跑庫系統
/// </summary>
public class Player : MonoBehaviour
{
    #region 欄位
    // 跑步速度、跳躍高度、是否滑行、是否死亡
    // 動畫參數跳躍、滑行與死亡
    // Header 標題
    // Range 範圍 : 僅限於數值型態資料，float、int
    // Tooltip 提示
    [Header("跑步速度"), Range(0, 500)]
    public float speed = 1.5f;
    [Header("跳躍高度"), Range(0, 5000)]
    public int jump = 500;
    [Tooltip("儲存角色是否在滑行")]
    public bool isSlide;
    [Tooltip("儲存角色是否死亡")]
    public bool isDead;

    public string parameterJump = "觸發跳躍";
    public string parameterSlide = "開關滑行";
    public string parameterDead = "觸發死亡";

    [Header("跳躍案件")]
    public KeyCode KeyJump = KeyCode.Space;

    // 存取 Transform 第一種方式
    // public Transform traPlayer;
    #endregion

    // 屬性面板 ... > Debug 模式可以看到私人資料
    private Rigidbody2D rig;

    [Header("跳躍段數最大值"), Range(0, 5)]
    public int countJumpMax = 2;

    public int countJump;

    #region 事件
    private void Update()
    {
        // GetComponent<元件類型>() - <> 泛型 ， 所有類型
        // 取得指定元件
        rig = GetComponent<Rigidbody2D>();
    }
    public Transform traPlayer;
    #endregion

    #region 方法
    /// <summary>
    /// 跑步
    /// </summary>
    private void Run()
    {
        // 存取  Transform 第一種方式
        // 玩家變形.位移(x ， y ， z)
        // Time.deltaTime 一幀 的時間
        // traPlayer.Translate(speed * Time.deltaTime, 0 , 0);

        // 存取  Transform 第二種方式
        // 1. 當要控制的 Transform 與此元件同一階層
        // 語法 :
        // Transform.成員名稱
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    /// <summary>
    /// 跳躍
    /// </summary>
    private void Jump()
    {
        bool inputJump = Input.GetKeyDown(KeyJump);
        // print("是否按下跳躍 : " + inputJump);
        if (inputJump)
        {
            // print("跳躍");
            // 鋼體.添加推力(二維向量)
            rig.AddForce(new Vector2(0, jump));
        }
    }
    #endregion
}

