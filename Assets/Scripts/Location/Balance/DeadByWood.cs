using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadByWood : MonoBehaviour
{
    private GameObject person;
    private void Start()
    {
        person = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (person.GetComponent<Life>().Gamemode == false)
            {
                if (person.GetComponent<Player>().Mod == 1)
                {
                    SceneManager.LoadScene("Balance");
                    Time.timeScale = 1;
                }
                else if (person.GetComponent<Player>().Mod == 2)
                {
                    SceneManager.LoadScene("BalanceMod");
                    Time.timeScale = 1;
                }
                else if (person.GetComponent<Player>().Mod == 3)
                {
                    SceneManager.LoadScene("GoldMod");
                    Time.timeScale = 1;
                }
            }
        }
    }
}
