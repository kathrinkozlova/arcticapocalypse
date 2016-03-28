using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour
{


    public int Damage;
    public float ReloadTime;
    public float FireTime;
    public float FireRate;
    public static int BulletsInClip;
    public static int BulletsLeft;
    private float NextFireTime = 0.0f;
    private bool Reloading = false;
    private Animator anim;



    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();

        BulletsLeft = BulletsInClip;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire2"))
        {
            Attack();

        }
        if (!Input.GetButton("Fire2"))
        {
            anim.SetBool("Attack", false);

        }
        if ((BulletsLeft <= 0) && (!Reloading))
        {
            Reload();
        }
        if ((Input.GetKeyDown(KeyCode.R)) && (!Reloading))
        {
            Reload();
        }




    }
    private void Reload()
    {

        Reloading = true;
        anim.SetBool("Attack", false);
        Invoke("ReloadingOf", ReloadTime);

    }

    private void ReloadingOf()
    {

        BulletsLeft = BulletsInClip;
        Reloading = false;

    }

    public void Attack()
    {

        if (BulletsLeft == 0)
            return;
        if (Time.time - FireRate > NextFireTime)
            NextFireTime = Time.time - Time.fixedDeltaTime;


        if (NextFireTime < Time.time && BulletsLeft != 0 && !Reloading)
        {
            anim.SetBool("Attack", true);
            NextFireTime += FireRate;
            Vector2 SecVect = new Vector2(transform.position.x - 0.4f, transform.position.y);
            RaycastHit2D Hit;
            transform.rigidbody2D.AddForce(Vector2.right * 10000 * Time.fixedDeltaTime, ForceMode2D.Force);
            Hit = Physics2D.Raycast(SecVect, -1 * Vector2.right, 100f);
            BulletsLeft--;
            Global.AmmoSpend++;
            if (Hit.collider.tag == "Enemy")
            {
                var Enemy = Hit.collider.gameObject.GetComponent<MobHP>();
                Enemy.Damage(Damage);
                
            }
        }

    }
}

