using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
    public Transform EnemyPrefab;
    public int MobCount = 0;
    private int k;
    public int waveAmount; //Количество мобов за 1 волну на каждой точке спауна
    public int waveNumber; //переменная текущей волны
    public float waveDelayTimer; //переменная таймера спауна волны
    public float waveCooldown; //переменная для сброса таймера выше
    public int maximumWaves; //максимальное количество мобов в игре
    public GameObject[] SpawnPoints; //массив точек спауна


    private void Awake()
    {
       SpawnPoints = GameObject.FindGameObjectsWithTag("Spawnpoint");
      
    }

	// Use this for initialization
	void Start () {
        
	}


	// Update is called once per frame
    void Update()
    {
      
            if (waveDelayTimer > 0)
            {
                if (MobCount == 0)
                    waveDelayTimer = 0;
                else
                    waveDelayTimer -= Time.fixedDeltaTime;

            }

            if (waveDelayTimer <= 0)
            {
                if (SpawnPoints != null && waveNumber < maximumWaves)
                {
                    foreach (GameObject Spawnpoint in SpawnPoints)
                    {
                        for (int i = 0; i < waveAmount; i++)
                        {
                            var EnemyN = Instantiate(EnemyPrefab) as Transform;
                            EnemyN.position = new Vector2(Spawnpoint.transform.position.x, Spawnpoint.transform.position.y * Random.Range(-2.5F, 2.0F));
                            k = i;
                        }


                        MobCount += k + 1;

                        if (waveCooldown > 5.0f)
                        {
                            waveCooldown -= 0.1f;
                            waveDelayTimer = waveCooldown;
                        }
                        else
                        {
                            waveCooldown = 5.0f;
                            waveDelayTimer = waveCooldown;
                        }
                    }
                    waveNumber++;

                }
            }
        }
    
}

