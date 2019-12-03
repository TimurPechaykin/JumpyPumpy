using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Potion2 : MonoBehaviour
{
    public GameObject person;
    public Text _Potion2;

    private void Start()
    {
        _Potion2.text = PlayerPrefs.GetInt("Potion2").ToString();
    }
    public void OnPotion2()
    {
        if (PlayerPrefs.GetInt("Potion2") > 0)
        {
            person.GetComponent<Life>().LifePlusPotion();
            _Potion2.text = PlayerPrefs.GetInt("Potion2").ToString();
            PlayerPrefs.Save();
        }
    }
}
