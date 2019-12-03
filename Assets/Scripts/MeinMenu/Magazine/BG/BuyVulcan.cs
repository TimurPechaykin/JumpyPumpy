using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyVulcan : MonoBehaviour
{
    public GameObject Lock1;
    public GameObject Lock2;
    public Text Kupleno1;
    public Text Kupleno2;
    public GameObject GoldIcon1;
    public GameObject GoldIcon2;
    public AudioSource BuySound;
    public Text Gold;
    private void Start()
    {
        if (PlayerPrefs.GetInt("2Mod") == 1)
        {
            if (PlayerPrefs.GetInt("Language") == 0)
                Kupleno1.text = "Bought";
            else
                Kupleno1.text = "Куплено";
            Kupleno1.color = new Color32(171, 28, 28, 255);
            Destroy(GoldIcon1);
            Destroy(Lock1);
        }
        if (PlayerPrefs.GetInt("3Mod") == 1)
        {
            if (PlayerPrefs.GetInt("Language") == 0)
                Kupleno2.text = "Bought";
            else
                Kupleno2.text = "Куплено";
            Kupleno2.color = new Color32(171, 28, 28, 255);
            Destroy(GoldIcon2);
            Destroy(Lock2);
        }
    }
    private void Update()
    {
        if (PlayerPrefs.GetInt("2Mod") == 1)
        {
            if (PlayerPrefs.GetInt("Language") == 0)
                Kupleno1.text = "Bought";
            else
                Kupleno1.text = "Куплено";
            Kupleno1.color = new Color32(171, 28, 28, 255);
            Destroy(GoldIcon1);
            Destroy(Lock1);
        }
        if (PlayerPrefs.GetInt("3Mod") == 1)
        {
            if (PlayerPrefs.GetInt("Language") == 0)
                Kupleno2.text = "Bought";
            else
                Kupleno2.text = "Куплено";
            Kupleno2.color = new Color32(171, 28, 28, 255);
            Destroy(GoldIcon2);
            Destroy(Lock2);
        }
    }
    public void Buy2BG()
    {
        if (PlayerPrefs.HasKey("2Mod") == false)
        {
            if(PlayerPrefs.GetInt("Money")>= 30000)
            {
                BuySound.Play();
                PlayerPrefs.SetInt("2Mod", 1);
                PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 30000);
                Destroy(Lock1);
                Kupleno1.text = "Куплено";
                Kupleno1.color = new Color32(171,28,28,255);
                Destroy(GoldIcon1);
                Gold.text = PlayerPrefs.GetInt("Money").ToString();
                PlayerPrefs.SetInt("BG", 1);
            }
        }
    }
    public void Buy3BG()
    {
        if (PlayerPrefs.HasKey("3Mod") == false)
        {
            if (PlayerPrefs.GetInt("Money") >= 30000)
            {
                BuySound.Play();
                PlayerPrefs.SetInt("3Mod", 1);
                PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 30000);
                Destroy(Lock2);
                Kupleno2.text = "Куплено";
                Kupleno2.color = new Color32(171, 28, 28, 255);
                Destroy(GoldIcon2);
                Gold.text = PlayerPrefs.GetInt("Money").ToString();
                PlayerPrefs.SetInt("BG", 2);
            }
        }
    }
}
