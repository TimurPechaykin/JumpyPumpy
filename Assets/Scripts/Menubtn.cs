using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menubtn : MonoBehaviour
{
    private int money;
    public void OnClickMenu()
    {
        money = PlayerPrefs.GetInt("Money");
        PlayerPrefs.SetInt("Money", money);
        PlayerPrefs.Save();
        SceneManager.LoadScene("MainMenu");
    }
    
}
