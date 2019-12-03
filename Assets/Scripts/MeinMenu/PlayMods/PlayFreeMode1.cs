using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayFreeMode1 : MonoBehaviour
{
    public GameObject Panel;
    public void OnPlay()
    {
        if (Panel.GetComponent<PlayFreeMode>().Mode == 1)
        {
            SceneManager.LoadScene("Balance");
            Time.timeScale = 1;
        }
        else if (Panel.GetComponent<PlayFreeMode>().Mode == 2)
        {
            SceneManager.LoadScene("BalanceMod");
            Time.timeScale = 1;
        }
        else if (Panel.GetComponent<PlayFreeMode>().Mode == 3)
        {
            SceneManager.LoadScene("GoldMod");
            Time.timeScale = 1;
        }
    }
}
