using UnityEngine;
using System.Collections;
using System.Timers;

public class Player : MonoBehaviour
{
    private Animator anim;
    // Use this for initialization


    void Start()
    {
        anim = GetComponent<Animator>();


    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Physics2D.IgnoreCollision(col.gameObject.collider2D, collider2D);
        }
    }


    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {

        float MoveX = Input.GetAxis("Horizontal");
        float MoveY = Input.GetAxis("Vertical");
        if ((MoveX != 0) || (MoveY != 0))
        {
            if (MoveX != 0)
                anim.SetFloat("Speed", Mathf.Abs(MoveX));
            else
                anim.SetFloat("Speed", Mathf.Abs(MoveY));
        }
        else
            anim.SetFloat("Speed", 0);
        rigidbody2D.velocity = new Vector2(Global.Speed.x * MoveX, Global.Speed.y * MoveY);



    }

}

