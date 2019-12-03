using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectBG : MonoBehaviour
{
    public GameObject Btn0On;
    public GameObject Btn1On;
    public GameObject Btn2On;
    public Sprite BtnOnSprite;
    public Sprite BtnOffSprite;
    private void Update()
    {
        if (PlayerPrefs.GetInt("BG") == 0)
        {
            Btn0On.GetComponent<Image>().sprite = BtnOnSprite;
            Btn1On.GetComponent<Image>().sprite = BtnOffSprite;
            Btn2On.GetComponent<Image>().sprite = BtnOffSprite;
        }
        else if(PlayerPrefs.GetInt("BG") == 1)
        {
            Btn0On.GetComponent<Image>().sprite = BtnOffSprite;
            Btn1On.GetComponent<Image>().sprite = BtnOnSprite;
            Btn2On.GetComponent<Image>().sprite = BtnOffSprite;
        }
        else if (PlayerPrefs.GetInt("BG") == 2)
        {
            Btn0On.GetComponent<Image>().sprite = BtnOffSprite;
            Btn1On.GetComponent<Image>().sprite = BtnOffSprite;
            Btn2On.GetComponent<Image>().sprite = BtnOnSprite;
        }
    }
    public void SelectB0()
    {
        PlayerPrefs.SetInt("BG", 0);
    }
    public void SelectB1()
    {
        if (PlayerPrefs.GetInt("2Mod") == 1)
        {
            PlayerPrefs.SetInt("BG", 1);
        }
    }
    public void SelectB2()
    {
        if (PlayerPrefs.GetInt("3Mod") == 1)
        {
            PlayerPrefs.SetInt("BG", 2);
        }
    }
    
}
