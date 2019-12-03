using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocalisIMG : MonoBehaviour
{
    private Sprite WriteRussian;
    public Sprite WriteEnglish;
    private Image image;
    private void Awake()
    {
        WriteRussian = gameObject.GetComponent<Image>().sprite;
        image = gameObject.GetComponent<Image>();
        if (PlayerPrefs.GetInt("Language") == 1)
            image.sprite = WriteRussian;
        else
            image.sprite = WriteEnglish;
    }
    private void Update()
    {
        if (PlayerPrefs.GetInt("Language") == 1)
            image.sprite = WriteRussian;
        else
            image.sprite = WriteEnglish;
    }
}
