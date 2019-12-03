using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyPlus : MonoBehaviour
{
    public GameObject Timemod;
    public Text Money;

    public void Start()
    {
        StartCoroutine("Rotatealways");
        Timemod = GameObject.Find("textcount");
        Money = GameObject.Find("GoldText").GetComponent<Text>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Timemod.GetComponent<Time3Mod>().Moneytake++;
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + 15);
            Money.text = PlayerPrefs.GetInt("Money").ToString();
            Destroy(gameObject);
        }
    }
    IEnumerator Rotatealways()
    {
        int i= 0;
        while (true)
        {

            transform.rotation = Quaternion.Euler(0, 0, i);
            i++;
            yield return new WaitForSeconds(0.00001f);

        }
    }
}
