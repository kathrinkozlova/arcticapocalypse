using UnityEngine;
using System.Collections;

public class SwitchWeapon : MonoBehaviour
{

    public static int CurWeapon;
    public int MaxWeapons = 3;
    private int[] BulletsMass = { 10, 6, 30 };
    private Animator anim;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var weapon = GetComponent<Weapon>();
        if (Input.GetKeyDown(KeyCode.Q))
        {

            BulletsMass[CurWeapon] = Weapon.BulletsLeft;
            CurWeapon += 1;
            if (CurWeapon == MaxWeapons)
            {
                CurWeapon = 0;
            }
            Weapon.BulletsLeft = BulletsMass[CurWeapon];
        }

        if (CurWeapon == 0)
        {
            CurWeapon = 0;
            weapon.Damage = 1;
            Weapon.BulletsInClip = 10;
            weapon.FireRate = 0.7f;
            weapon.FireTime = 0.7f;
            weapon.ReloadTime = 1f;
            anim.SetBool("ChangeWeaponAK", false);
            anim.SetBool("ChangeWeaponPistolet", true);
        }

        if (CurWeapon == 1)
        {
            CurWeapon = 1;
            weapon.Damage = 2;
            Weapon.BulletsInClip = 6;
            weapon.FireRate = 1;
            weapon.FireTime = 1;
            weapon.ReloadTime = 1.3f;
        }

        if (CurWeapon == 2)
        {
            CurWeapon = 2;
            weapon.Damage = 4;
            Weapon.BulletsInClip = 30;
            weapon.FireRate = 0.1f;
            weapon.FireTime = 0.1f;
            weapon.ReloadTime = 2f;
            anim.SetBool("ChangeWeaponPistolet", false);
            anim.SetBool("ChangeWeaponAK", true);

        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            if (Global.MoneyEarned >= 10 & Global.MoneyEarned <= 19)
            {
                CurWeapon = 2;
                Global.PlayerMoney -= 10;
            }


            if (Global.MoneyEarned >= 20 & Global.MoneyEarned <= 29)
            {
                CurWeapon = 3;
                Global.PlayerMoney -= 20;
            }
        }
    }
}