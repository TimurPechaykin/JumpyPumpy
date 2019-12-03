using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time3Mod : MonoBehaviour
{
    public Text Money;
    public Text TakeGold;
    public Text Gold;
    public int Moneytake;
    public bool CanAddMoney;
    private RainingMod3 rm;
    private void Start()
    {
        rm = GameObject.FindGameObjectWithTag("Player").GetComponent<RainingMod3>();
        CanAddMoney = true;
        Gold.text = PlayerPrefs.GetInt("Money").ToString();
        Money.text = Moneytake.ToString();
        TakeGold.text = PlayerPrefs.GetInt("AddMoney").ToString();
    }
    private void Update()
    {
        
        Money.text = Moneytake.ToString();
        if (Moneytake > PlayerPrefs.GetInt("AddMoney"))
        {
            PlayerPrefs.SetInt("AddMoney", Moneytake);
            TakeGold.text = PlayerPrefs.GetInt("AddMoney").ToString();
        }
        if (Moneytake % 50 == 0 && Moneytake != 0)
        {
            if (CanAddMoney == true)
            {
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + 1000);
            Gold.text = PlayerPrefs.GetInt("Money").ToString();
            CanAddMoney = false;
            }
        }
        if (Moneytake % 25 == 0 && Moneytake != 0)
        {
            if (CanAddMoney == true)
            {
                PlayerPrefs.SetInt("Money",PlayerPrefs.GetInt("Money") + 600);
                Gold.text = PlayerPrefs.GetInt("Money").ToString();
                CanAddMoney = false;
            }
            

        }
        
        else 
        {
            CanAddMoney = true;
        }
        if (Moneytake > 10 && Moneytake < 20)
        {
            rm.wait = 0.22f;
        }
        else if (Moneytake > 20&& Moneytake < 30)
        {
            rm.wait = 0.19f;
        }
        else if (Moneytake > 30)
        {
            rm.wait = 0.16f;
        }
    }  

}
