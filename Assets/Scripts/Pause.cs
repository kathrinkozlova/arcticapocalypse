using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pause : MonoBehaviour
{

    private bool Paused = false;
    public Text PauseText;
    // Use this for initialization
    void Start()
    {
    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.P))
        {

            Paused = !Paused;
            if (Paused)
            {
                PauseText.text = "Pause";
                Time.timeScale = 0;
                GameObject.FindGameObjectWithTag("Player").GetComponent<Weapon>().enabled = false;
                GameObject.FindGameObjectWithTag("Spawnpoint").GetComponent<Spawner>().enabled = false;
                GameObject.FindGameObjectWithTag("Player").GetComponent<SwitchWeapon>().enabled = false;
            }
            else
            {
                PauseText.text = "";
                Time.timeScale = 1;
                GameObject.FindGameObjectWithTag("Player").GetComponent<Weapon>().enabled = true;
                GameObject.FindGameObjectWithTag("Spawnpoint").GetComponent<Spawner>().enabled = true;
                GameObject.FindGameObjectWithTag("Player").GetComponent<SwitchWeapon>().enabled = true;
            }        
        }
        
    }

}
