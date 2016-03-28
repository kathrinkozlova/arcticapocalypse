using UnityEngine;
using System.Collections;

public class BonusSpawn : MonoBehaviour
{
    private GameObject[] Ices;
    public Transform BonusBox;
    public float BonusTimer = 0;

    void Start()
    {
        BonusTimer = Random.Range(10.0F, 15.0F);
    }

    // Update is called once per frame
    void Update()
    {
        BonusTimer -= Time.fixedDeltaTime;
        if (Global.Timer > 0)
        Global.Timer -= Time.fixedDeltaTime;

        if (BonusTimer <= 0)
        {
            BonusTimer = Random.Range(10.0F, 15.0F);
            var bonus = Instantiate(BonusBox) as Transform;
            bonus.transform.position = new Vector2(transform.position.x * Random.Range(-2f, 2f), transform.position.y * Random.Range(-2f, 4f));
        }

        if (Global.Timer <= 0)
        {
            Global.Speed = new Vector2(3, 3);
            Global.MobSpeed = new Vector2(1, 0);
            Ices = GameObject.FindGameObjectsWithTag("Ice");
            foreach (GameObject Icces in Ices)
            {
                DestroyObject(Icces);
            }

            var Script = GameObject.FindGameObjectsWithTag("SpawnScript");
            foreach (GameObject Scripts in Script)
            {
                Scripts.GetComponent<Spawner>().enabled = true;
            } 

        }
    }
}

