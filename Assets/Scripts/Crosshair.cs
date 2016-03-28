using UnityEngine;
using System.Collections;

public class Crosshair : MonoBehaviour {

    public Texture2D CrosshairTexture;
    public Rect Position;
    public Vector2 posVector;
    public Vector3 Vect;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnGUI()
    {
        Vect = transform.position;
        posVector = Camera.main.WorldToScreenPoint(transform.position);
        Position.x = posVector.x  - 35;
        Position.y = posVector.y + 50;
        Position.width = 20;
        Position.height = 20;
        GUI.DrawTexture(Position, CrosshairTexture);
    
    }
}
