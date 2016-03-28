using UnityEngine;
using System.Collections;

public class BonusAI : MonoBehaviour {

    
    private Vector2 boost;
    private int i;
    private int RandomChoose;
    private float DestroyTimer;
    private Animator anim;
    public GameObject Ice;
    private GameObject[] Mobs;
    private bool SpeedUse, FreezeUse = false;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (RandomChoose == 1)
            {
                Global.MoneyEarned += 100;
            }

            if (RandomChoose == 2)
            {
                Global.Timer = 3;
                Global.Speed = new Vector2(6, 6);
            }

            if (RandomChoose == 3)
            {
                Global.Timer = 7;
                var Script = GameObject.FindGameObjectsWithTag("SpawnScript");
                foreach (GameObject Scripts in Script)
                {
                    Scripts.GetComponent<Spawner>().enabled = false;
                }
                Mobs = GameObject.FindGameObjectsWithTag("Enemy");
                foreach (GameObject Mobbs in Mobs)
                {
                   var NewIce = (GameObject)Instantiate(Ice, new Vector2(Mobbs.transform.position.x, Mobbs.transform.position.y - 0.3f), Quaternion.identity);
                   NewIce.transform.parent = Mobbs.transform;
                }
                Global.MobSpeed = new Vector2(0, 0);    
            }

            Destroy(gameObject);
        }   
    }

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        RandomChoose = Random.Range(1, 4);

        if (RandomChoose == 1)
        {
            anim.SetFloat("BMoney", 1);
        }

        if (RandomChoose == 2)
        {
            anim.SetFloat("BSpeed", 1);
        }

        if (RandomChoose == 3)
        {
            anim.SetFloat("DFreeze", 1);
        }

        Debug.Log(RandomChoose + "");
        DestroyTimer = 10;
	}
	
	// Update is called once per frame
	void Update () 
    {
        DestroyTimer -= Time.fixedDeltaTime;

        if (DestroyTimer <= 0)
            Destroy(gameObject);
	}
}
