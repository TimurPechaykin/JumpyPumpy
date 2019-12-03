using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBaks : MonoBehaviour
{
    public Text Baksis;

    private void Start()
    {
        Baksis.text = PlayerPrefs.GetInt("Money").ToString();
        PlayerPrefs.Save();
    }

}
