using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Localis1object : MonoBehaviour
{
    public string WriteRussian;
    public string WriteEnglish;
    private Text txt;
    private void Start()
    {
        txt = gameObject.GetComponent<Text>();
        if (PlayerPrefs.GetInt("Language") == 1)
            txt.text = WriteRussian;
        else
            txt.text = WriteEnglish;
    }
    private void Update()
    {
        if (PlayerPrefs.GetInt("Language") == 1)
            txt.text = WriteRussian;
        else
            txt.text = WriteEnglish;
    }
}
