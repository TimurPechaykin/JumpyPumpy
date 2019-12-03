using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Wood : MonoBehaviour
{
    private bool canAddGold;
    public Text Gold;
    public Text Score;
    public Text HighScore;
    public int BalanceValueNow;

    private void Start()
    {
        Gold.text = PlayerPrefs.GetInt("Money").ToString();
        Score.text = "0";
        HighScore.text = PlayerPrefs.GetInt("BalanceValue").ToString();
        canAddGold = true;
    }
    private void Update()
    {
        if (transform.rotation.z > -0.03f && transform.rotation.z < 0.03f)
        {
            StartCoroutine("AddGold");
        }
    }
    IEnumerator AddGold()
    {
        if(canAddGold == true)
        {
            canAddGold = false;
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + 10);
            BalanceValueNow++;
            if(BalanceValueNow % 20 == 0)
                PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + 200);
            Score.text = BalanceValueNow.ToString();
            Gold.text = PlayerPrefs.GetInt("Money").ToString();
            if (BalanceValueNow > PlayerPrefs.GetInt("BalanceValue"))
            {
                PlayerPrefs.SetInt("BalanceValue", BalanceValueNow);
                HighScore.text = PlayerPrefs.GetInt("BalanceValue").ToString();
            }
            yield return new WaitForSeconds(0.5f);
            canAddGold = true;
        }
    }
}
