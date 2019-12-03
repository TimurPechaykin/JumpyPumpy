using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pointer : MonoBehaviour
{
    public GameObject person;
    public Text Potion1;
    private void Start()
    {
        Potion1.text = PlayerPrefs.GetInt("Potion1").ToString();
    }
    public void OnPotion()
    {
        if (PlayerPrefs.GetInt("Potion1") > 0)
        {
            person.GetComponent<Life>().StartCoroutine("GamemodePotion");
            Potion1.text = PlayerPrefs.GetInt("Potion1").ToString();
            PlayerPrefs.Save();
        }  
    }

}
