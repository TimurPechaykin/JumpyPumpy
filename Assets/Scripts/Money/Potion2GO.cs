using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Potion2GO : MonoBehaviour
{
    public Text Baksis;
    public Text Potion2;
    public AudioSource buySound;
    private void Start()
    {
        buySound = gameObject.GetComponent<AudioSource>();
        Potion2.text = PlayerPrefs.GetInt("Potion2").ToString();
    }
    public void OnBuyPotionHealth()
    {
        if (PlayerPrefs.GetInt("Money") >= 400)
        {
            PlayerPrefs.HasKey("Potion2");
            PlayerPrefs.SetInt("Potion2", PlayerPrefs.GetInt("Potion2") + 1);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 400);
            Baksis.text = PlayerPrefs.GetInt("Money").ToString();
            buySound.Play();
            Potion2.text = PlayerPrefs.GetInt("Potion2").ToString();
            PlayerPrefs.Save();
        }
    }
}
