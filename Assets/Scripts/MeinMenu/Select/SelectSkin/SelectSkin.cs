using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectSkin : MonoBehaviour
{
    public GameObject Btn0On;
    public GameObject Btn1On;
    public GameObject Btn2On;
    public GameObject Btn3On;
    public Sprite BtnOnSprite;
    public Sprite BtnOffSprite;
    private void Start()
    {
        if (PlayerPrefs.GetInt("Skin") == 0)
        {
            Btn0On.GetComponent<Image>().sprite = BtnOnSprite;
            Btn1On.GetComponent<Image>().sprite = BtnOffSprite;
            Btn2On.GetComponent<Image>().sprite = BtnOffSprite;
            Btn3On.GetComponent<Image>().sprite = BtnOffSprite;
        }
        else if (PlayerPrefs.GetInt("Skin") == 1)
        {
            Btn0On.GetComponent<Image>().sprite = BtnOffSprite;
            Btn1On.GetComponent<Image>().sprite = BtnOnSprite;
            Btn2On.GetComponent<Image>().sprite = BtnOffSprite;
            Btn3On.GetComponent<Image>().sprite = BtnOffSprite;
        }
        else if (PlayerPrefs.GetInt("Skin") == 2)
        {
            Btn0On.GetComponent<Image>().sprite = BtnOffSprite;
            Btn1On.GetComponent<Image>().sprite = BtnOffSprite;
            Btn2On.GetComponent<Image>().sprite = BtnOnSprite;
            Btn3On.GetComponent<Image>().sprite = BtnOffSprite;
        }
        else if (PlayerPrefs.GetInt("Skin") == 3)
        {
            Btn0On.GetComponent<Image>().sprite = BtnOffSprite;
            Btn1On.GetComponent<Image>().sprite = BtnOffSprite;
            Btn2On.GetComponent<Image>().sprite = BtnOffSprite;
            Btn3On.GetComponent<Image>().sprite = BtnOnSprite;
        }
    }
    public void SelectS0()
    {
        PlayerPrefs.SetInt("Skin", 0);
        Btn0On.GetComponent<Image>().sprite = BtnOnSprite;
        Btn1On.GetComponent<Image>().sprite = BtnOffSprite;
        Btn2On.GetComponent<Image>().sprite = BtnOffSprite;
        Btn3On.GetComponent<Image>().sprite = BtnOffSprite;
    }
    public void SelectS1()
    {
        if (PlayerPrefs.GetInt("2Skin") == 1)
        {
            PlayerPrefs.SetInt("Skin", 1);
            Btn0On.GetComponent<Image>().sprite = BtnOffSprite;
            Btn1On.GetComponent<Image>().sprite = BtnOnSprite;
            Btn2On.GetComponent<Image>().sprite = BtnOffSprite;
            Btn3On.GetComponent<Image>().sprite = BtnOffSprite;
        }
    }
    public void SelectS2()
    {
        if (PlayerPrefs.GetInt("3Skin") == 1)
        {
            PlayerPrefs.SetInt("Skin", 2);
            Btn0On.GetComponent<Image>().sprite = BtnOffSprite;
            Btn1On.GetComponent<Image>().sprite = BtnOffSprite;
            Btn2On.GetComponent<Image>().sprite = BtnOnSprite;
            Btn3On.GetComponent<Image>().sprite = BtnOffSprite;
        }
    }
    public void SelectS3()
    {
        if (PlayerPrefs.GetInt("4Skin") == 1)
        {
            PlayerPrefs.SetInt("Skin", 3);
            Btn0On.GetComponent<Image>().sprite = BtnOffSprite;
            Btn1On.GetComponent<Image>().sprite = BtnOffSprite;
            Btn2On.GetComponent<Image>().sprite = BtnOffSprite;
            Btn3On.GetComponent<Image>().sprite = BtnOnSprite;
        }
    }
}
