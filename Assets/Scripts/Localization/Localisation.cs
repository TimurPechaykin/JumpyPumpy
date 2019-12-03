using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Localisation : MonoBehaviour
{
    public Image English;
    public Image Russian;
    // Start is called before the first frame update
    private void Start()
    {
        if (PlayerPrefs.GetInt("Language") ==0)
        {
            Russian.color = new Color(2, 2, 2, 2);
            English.color = new Color32(255, 136, 136, 255);
        }
        if (PlayerPrefs.GetInt("Language") == 1)
        {
            English.color = new Color(2, 2, 2, 2);
            Russian.color = new Color32(255, 136, 136, 255);
        }
    }
    public void SelectEnglish()
    {
        PlayerPrefs.SetInt("Language", 0);
        Russian.color = new Color(2, 2, 2, 2);
        English.color = new Color32(255, 136, 136, 255);
    }
    public void SelectRussian()
    {
        PlayerPrefs.SetInt("Language", 1);
        Russian.color = new Color32(255, 136, 136, 255);
        English.color = new Color(2, 2, 2, 2);
    }
}
