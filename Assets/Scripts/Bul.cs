using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Bul : MonoBehaviour {
    public Text Ammo;
    public Text moneyEarned;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        Ammo.text = "Ammo :" + Weapon.BulletsLeft.ToString() + "/" + Weapon.BulletsInClip.ToString();
        moneyEarned.text = "Money Earned :" + Global.MoneyEarned.ToString();
	}
}
