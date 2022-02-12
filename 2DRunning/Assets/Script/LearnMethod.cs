using UnityEngine;

/// <summary>
/// 厩策よ猭
/// </summary>
public class LearnMethod : MonoBehaviour
{
    // *よ猭粂猭
    // 勉猭 肚戈摸 よ猭嘿() {祘Αず甧朝瓃Α簍衡猭}
    // void 礚肚 : ㄏノよ猭ぃ穦Τ戈肚

    // 璹よ猭
    private void Start()
    {
        // ㊣璹よ猭
        // 璹よ猭嘿();
        Test();
        Test();
        shootFire();
        shootIce();
        // Τ碭把计碞璶块碭ま计
        // Τ箇砞把计ぃノ倒ま计箇砞
        shoot("瞴", 170);
        shoot("瞴", 80);
        shoot("筿瞴", 300, "逮逮逮");
    }

    // 璹よ猭 : ぃ穦笆磅︽ゲ斗㊣ ...
    private void Test() { }

    //祇甮瞴
    private void shootFire()
    {
        print("祇甮瞴");
        print("︽硉 100");
        print("祇甮");
    }

    private void shootIce()
    {
        print("祇甮瞴");
        print("︽硉 50");
        print("祇甮");
    }

    // 蝴臔┦籔耎┦
    // 把计粂猭 : 把计1摸 把计1嘿, 把计2摸 把计2嘿
    // 把计箇砞 : 把计摸 把计嘿 = 箇砞
    // *Τ箇砞把计ゲ斗
    private void shoot(string type, int speed, string sound = "")
    {
        print("<coior=yellow祇甮>" + type + "</color");
        print("<color=yellow>︽硉" + speed + "</color>");
        print("<color=yeiiow>祇甮" + sound + "</color>");
    }


}
