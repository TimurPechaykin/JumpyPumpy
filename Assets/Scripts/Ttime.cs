using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ttime : MonoBehaviour
{
    public Text Baksis;
    public int sec;
    public Text textwrite;
    public Text Highscore;
    public string time;

    public void Start()
    {
        if (PlayerPrefs.GetInt("Language") == 1)
            time = "Время : ";
        else
            time = "Time : "; 
        Baksis.text = PlayerPrefs.GetInt("Money").ToString();
        Highscore.text =PlayerPrefs.GetInt("Time", 0).ToString();
        Debug.Log((PlayerPrefs.HasKey("Money")) + "Haskey");
        sec = 0;
        StartCoroutine("Timme");
        textwrite.text = time + sec;
    }
    
    
    public IEnumerator Timme()
    {
        Baksis.text = PlayerPrefs.GetInt("Money").ToString();


        while (true)
        {
            yield return new WaitForSeconds(1);
            sec++;
            if (sec % 5 == 0)
            {
                PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") +25);
                PlayerPrefs.Save();
            }
            if (sec % 25 == 0)
            {
                
                    
                    PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + 100);
                    PlayerPrefs.Save();
                
            }
            if (sec % 50 == 0)
            {


                PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + 250);
                PlayerPrefs.Save();

            }
            if (sec % 100 == 0)
            {


                PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + 700);
                PlayerPrefs.Save();

            }
            textwrite.text = time + sec;
            if (sec > PlayerPrefs.GetInt("Time",0))
            {
                PlayerPrefs.SetInt("Time",sec);
                Highscore.text = PlayerPrefs.GetInt("Time", 0).ToString();
            }
            Baksis.text = PlayerPrefs.GetInt("Money").ToString();


        }
        
    }
}
