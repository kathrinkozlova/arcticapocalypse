using UnityEngine;
using System.Collections;

public class Select : MonoBehaviour {
    public GameObject Girl;
    public GameObject Boy;
	// Use this for initialization
	void Start () {
        if (SelectHero.HBoy)
            GameObject.Instantiate(Boy);
        if (SelectHero.HGirl)
            GameObject.Instantiate(Girl);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
