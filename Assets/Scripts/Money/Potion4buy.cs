using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Potion4buy : MonoBehaviour
{
    public Text PotionFreezeAmount;
    public Text Gold;
    public AudioSource buySound;
    private void Start()
    {
        buySound = gameObject.GetComponent<AudioSource>();
        PotionFreezeAmount.text = PlayerPrefs.GetInt("Potion4").ToString();
    }
    public void BuyFreezePotion()
    {
        if (PlayerPrefs.GetInt("Money") >= 350)
        {
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 350);
            PlayerPrefs.SetInt("Potion4", PlayerPrefs.GetInt("Potion4") + 1);
            Gold.text = PlayerPrefs.GetInt("Money").ToString();
            buySound.Play();
            PotionFreezeAmount.text = PlayerPrefs.GetInt("Potion4").ToString(); 
        }
    } 
}
