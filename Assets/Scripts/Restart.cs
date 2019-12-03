using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public GameObject Player;
    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    public void restart()
    {
        if (Player.GetComponent<Player>().Mod == 1)
        {
            SceneManager.LoadScene("Balance", LoadSceneMode.Single);
            Time.timeScale = 1f;
        }
        if (Player.GetComponent<Player>().Mod == 2)
        {
            SceneManager.LoadScene("BalanceMod", LoadSceneMode.Single);
            Time.timeScale = 1f;
        }
        if (Player.GetComponent<Player>().Mod == 3)
        {
            SceneManager.LoadScene("GoldMod", LoadSceneMode.Single);
            Time.timeScale = 1f;
        }
    }
}
