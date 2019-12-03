using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuySkin : MonoBehaviour
{
    public GameObject Lock1;
    public GameObject Lock2;
    public GameObject Lock3;
    public Text Kupleno1;
    public Text Kupleno2;
    public Text Kupleno3;
    public GameObject GoldIcon1;
    public GameObject GoldIcon2;
    public GameObject GoldIcon3;
    public AudioSource BuySound;
    public Text Gold;
    public SelectSkin SS;
    private void Start()
    {
        if (PlayerPrefs.GetInt("2Skin") == 1)
        {
            if (PlayerPrefs.GetInt("Language") == 0)
                Kupleno1.text = "Bought";
            else
                Kupleno1.text = "Куплено";
            Kupleno1.color = new Color32(171, 28, 28, 255);
            Destroy(GoldIcon1);
            Destroy(Lock1);
        }
        if (PlayerPrefs.GetInt("3Skin") == 1)
        {
            if (PlayerPrefs.GetInt("Language") == 0)
                Kupleno2.text = "Bought";
            else
                Kupleno2.text = "Куплено";
            Kupleno2.color = new Color32(171, 28, 28, 255);
            Destroy(GoldIcon2);
            Destroy(Lock2);
        }
        if (PlayerPrefs.GetInt("4Skin") == 1)
        {
            if (PlayerPrefs.GetInt("Language") == 0)
                Kupleno3.text = "Bought";
            else
                Kupleno3.text = "Куплено";
            Kupleno3.color = new Color32(171, 28, 28, 255);
            Destroy(GoldIcon3);
            Destroy(Lock3);
        }
    }
    private void Update()
    {
        if (PlayerPrefs.GetInt("2Skin") == 1)
        {
            if (PlayerPrefs.GetInt("Language") == 0)
                Kupleno1.text = "Bought";
            else
                Kupleno1.text = "Куплено";
            Kupleno1.color = new Color32(171, 28, 28, 255);
            Destroy(GoldIcon1);
            Destroy(Lock1);
        }
        if (PlayerPrefs.GetInt("3Skin") == 1)
        {
            if (PlayerPrefs.GetInt("Language") == 0)
                Kupleno2.text = "Bought";
            else
                Kupleno2.text = "Куплено";
            Kupleno2.color = new Color32(171, 28, 28, 255);
            Destroy(GoldIcon2);
            Destroy(Lock2);
        }
        if (PlayerPrefs.GetInt("4Skin") == 1)
        {
            if (PlayerPrefs.GetInt("Language") == 0)
                Kupleno3.text = "Bought";
            else
                Kupleno3.text = "Куплено";
            Kupleno3.color = new Color32(171, 28, 28, 255);
            Destroy(GoldIcon3);
            Destroy(Lock3);
        }
    }
    public void Buy2Skin()
    {
        if (PlayerPrefs.GetInt("2Skin") == 0)
        {
            if (PlayerPrefs.GetInt("Money") >= 10000)
            {
                BuySound.Play();
                PlayerPrefs.SetInt("2Skin", 1);
                PlayerPrefs.SetInt("Skin", 1);
                SS.Btn0On.GetComponent<Image>().sprite = SS.BtnOffSprite;
                SS.Btn1On.GetComponent<Image>().sprite = SS.BtnOnSprite;
                SS.Btn2On.GetComponent<Image>().sprite = SS.BtnOffSprite;
                SS.Btn3On.GetComponent<Image>().sprite = SS.BtnOffSprite;
                PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 10000);
                Destroy(Lock1);
                if (PlayerPrefs.GetInt("Language") == 0)
                    Kupleno1.text = "Bought";
                else
                    Kupleno1.text = "Куплено";
                Kupleno1.color = new Color32(171, 28, 28, 255);
                Destroy(GoldIcon1);
                Gold.text = PlayerPrefs.GetInt("Money").ToString();
            }
        }
    }
    public void Buy3Skin()
    {
        if (PlayerPrefs.GetInt("3Skin") == 0)
        {
            if (PlayerPrefs.GetInt("Money") >= 25000)
            {
                BuySound.Play();
                PlayerPrefs.SetInt("3Skin", 1);
                PlayerPrefs.SetInt("Skin", 2);
                SS.Btn0On.GetComponent<Image>().sprite = SS.BtnOffSprite;
                SS.Btn1On.GetComponent<Image>().sprite = SS.BtnOffSprite;
                SS.Btn2On.GetComponent<Image>().sprite = SS.BtnOnSprite;
                SS.Btn3On.GetComponent<Image>().sprite = SS.BtnOffSprite;
                PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 25000);
                Destroy(Lock2);
                if (PlayerPrefs.GetInt("Language") == 0)
                    Kupleno2.text = "Bought";
                else
                    Kupleno2.text = "Куплено";
                Kupleno2.color = new Color32(171, 28, 28, 255);
                Destroy(GoldIcon2);
                Gold.text = PlayerPrefs.GetInt("Money").ToString();
            }
        }
    }
    public void Buy4Skin()
    {
        if (PlayerPrefs.GetInt("4Skin") == 0)
        {
            if (PlayerPrefs.GetInt("Money") >= 40000)
            {
                BuySound.Play();
                PlayerPrefs.SetInt("4Skin", 1);
                PlayerPrefs.SetInt("Skin", 3);
                SS.Btn0On.GetComponent<Image>().sprite = SS.BtnOffSprite;
                SS.Btn1On.GetComponent<Image>().sprite = SS.BtnOffSprite;
                SS.Btn2On.GetComponent<Image>().sprite = SS.BtnOffSprite;
                SS.Btn3On.GetComponent<Image>().sprite = SS.BtnOnSprite;
                PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 40000);
                Destroy(Lock3);
                if (PlayerPrefs.GetInt("Language") == 0)
                    Kupleno3.text = "Bought";
                else
                    Kupleno3.text = "Куплено";
                Kupleno3.color = new Color32(171, 28, 28, 255);
                Destroy(GoldIcon3);
                Gold.text = PlayerPrefs.GetInt("Money").ToString();
            }
        }
    }
}
