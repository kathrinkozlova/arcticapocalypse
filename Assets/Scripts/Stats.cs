using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Stats : MonoBehaviour {
    public Text mobsKilled;
    public Text moneyEarned;
    public Text ammoSpend;
    public Text qwe;
	// Use this for initialization
	void Start () {
       
       mobsKilled.text = "Mob Killed :" + Global.MobsKilled;
       moneyEarned.text = "Money Earned :" + Global.MoneyEarned;
       ammoSpend.text = "Ammo Spend :" + Global.AmmoSpend;
        
        
	}
	
	// Update is called once per frame
	void Update () {
     
	}

  
}
