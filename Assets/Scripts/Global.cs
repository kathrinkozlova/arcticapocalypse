using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Global : MonoBehaviour
{
    public static int PlayerMoney = 0;
       
    public static List<GameObject> MobList = new List<GameObject>();
    public static int MobCount = 0;

    public static Vector2 Speed = new Vector2(3, 3);
    public static Vector2 MobSpeed = new Vector2(1, 0);

    public static float Timer;

    public static int MobsKilled = 0;
    public static int MoneyEarned = 0;
    public static int AmmoSpend = 0;

}
