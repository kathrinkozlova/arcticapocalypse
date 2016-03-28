using UnityEngine;
using System.Collections;

public class MobAI : MonoBehaviour {
    public int mobPrice = 10;
    public Vector2 Direction = new Vector2(1, 0);
    private Vector2 Movement;
    private bool End = false;

  	// Use this for initialization
	void Start () {

	}


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Bonus")
        {
            Physics2D.IgnoreCollision(col.gameObject.collider2D, collider2D);
        }
    }


    void OnTriggerEnter2D()
    {
        if (collider2D.gameObject.tag == "Enemy")
            End = true;
    }

	
	// Update is called once per frame
	void Update () {

        if (End)
            Application.LoadLevel(2);

        Movement = new Vector2(Global.MobSpeed.x * Direction.x, Global.MobSpeed.y * Direction.y);      
	}

    void FixedUpdate()
    {

        rigidbody2D.velocity = Movement;
    }
}
