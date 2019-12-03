using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Magazin : MonoBehaviour
{
    public Text Baksis;
    public Text Potion1;
    public AudioSource buySound;

    private void Start()
    {
        buySound = gameObject.GetComponent<AudioSource>();
        Potion1.text = PlayerPrefs.GetInt("Potion1").ToString();
    }
    public void OnBuyPotionGM()
    {
        if (PlayerPrefs.GetInt("Money") >= 400)
        {
            PlayerPrefs.HasKey("Potion1");
            PlayerPrefs.SetInt("Potion1", PlayerPrefs.GetInt("Potion1") + 1);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 400);
            Baksis.text = PlayerPrefs.GetInt("Money").ToString();
            Potion1.text = PlayerPrefs.GetInt("Potion1").ToString();
            buySound.Play();
            PlayerPrefs.Save();
        }
    }
    

}
