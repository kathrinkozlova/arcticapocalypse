using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void StartGame()
    {
        Global.AmmoSpend = 0;
        Global.MobsKilled = 0;
        Global.MoneyEarned = 0;
        SelectHero.HBoy = false;
        SelectHero.HGirl = false;
        Application.LoadLevel(3);
       
    }

    public void EndGame()
    {
        Application.LoadLevel(0);
    }
    
}
