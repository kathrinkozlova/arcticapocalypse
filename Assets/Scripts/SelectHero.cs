using UnityEngine;
using System.Collections;

public class SelectHero : MonoBehaviour {
    public static bool HBoy = false;
    public static bool HGirl = false;
    // Use this for initialization
	void Start () {
	 
	}

    public void SelectBoy()
    {
        HBoy = true;
        Application.LoadLevel(1);
    }
    
        public void SelectGirl()
    {
        HGirl = true;
        Application.LoadLevel(1);
    }

	// Update is called once per frame
	void Update () {
	
	}
}
