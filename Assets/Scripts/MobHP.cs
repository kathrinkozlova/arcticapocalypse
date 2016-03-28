using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MobHP : MonoBehaviour
{

    public int HP;
    public int MobsKilled;


    private void Awake()
    {
            Global.MobList.Add(gameObject);
            Global.MobCount++;
                       
        
    }

    // Use this for initialization

    public int Damage(int DamageCount)
    {
        HP -= DamageCount;
        if (HP <= 0)
        {
            MobAI mob = gameObject.GetComponent<MobAI>();
            Global.PlayerMoney += mob.mobPrice;
            Global.MobsKilled++;
            Global.MoneyEarned += mob.mobPrice;
            Destroy(gameObject);
        }
        return HP;
    }

    private void OnDestroy()
    {
        Global.MobList.Remove(gameObject);
        Global.MobCount--; 

    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

}
