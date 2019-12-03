using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldCollision : MonoBehaviour
{
    private Text gold;
    private GameObject person;
    private int mod;
    private void Start()
    {
        person = GameObject.FindGameObjectWithTag("Player");
        mod = person.GetComponent<Player>().Mod;
        gold = GameObject.Find("GoldText").GetComponent<Text>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
         PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + 30);
         gold.text = PlayerPrefs.GetInt("Money").ToString();
         Destroy(gameObject);
            
        }
    }
    
}
