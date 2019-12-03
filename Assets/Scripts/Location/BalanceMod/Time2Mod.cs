using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time2Mod : MonoBehaviour
{
    public Text Baksis;
    private int sec;
    public Text textwrite;
    public Text Highscore;
    public void Awake()
    {

    }
    public void Start()
    {
        Baksis.text = PlayerPrefs.GetInt("Money").ToString();
        Highscore.text = PlayerPrefs.GetInt("BalanceValue", 0).ToString();
        sec = 0;
        StartCoroutine("Timme");
        textwrite.text = "Time : " + sec;
    }


    public IEnumerator Timme()
    {


        while (true)
        {
            yield return new WaitForSeconds(1);
            sec++;
            
            
            textwrite.text = "Time : " + sec;
            if (sec > PlayerPrefs.GetInt("BalanceValue", 0))
            {
                PlayerPrefs.SetInt("BalanceValue", sec);
                Highscore.text = PlayerPrefs.GetInt("BalanceValue", 0).ToString();
            }


        }

    }
}
