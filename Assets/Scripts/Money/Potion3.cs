using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Potion3 : MonoBehaviour
{
    public Text Baksis;
    public Text _Potion3;
    public AudioSource buySound;

    private void Start()
    {
        buySound = gameObject.GetComponent<AudioSource>();
        _Potion3.text = PlayerPrefs.GetInt("Potion3").ToString();
    }
    public void OnBuyPotion()
    {
        if (PlayerPrefs.GetInt("Money") >= 300)
        {
            PlayerPrefs.HasKey("Potion3");
            PlayerPrefs.SetInt("Potion3", PlayerPrefs.GetInt("Potion3") + 1);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 300);
            Baksis.text = PlayerPrefs.GetInt("Money").ToString();
            buySound.Play();
            _Potion3.text = PlayerPrefs.GetInt("Potion3").ToString();
            PlayerPrefs.Save();
        }
    }
}
