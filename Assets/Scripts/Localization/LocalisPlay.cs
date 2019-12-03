using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocalisPlay : MonoBehaviour
{
    public Sprite WriteRussian1;
    public Sprite WriteEnglish1;
    public Sprite WriteRussian2;
    public Sprite WriteEnglish2;
    public Sprite WriteRussian3;
    public Sprite WriteEnglish3;
    private Image image;
    private void Awake()
    {
        image = gameObject.GetComponent<Image>();
    }
    private void Update()
    {
        if(gameObject.GetComponent<PlayFreeMode>().Mode == 2)
        {
            if (PlayerPrefs.GetInt("Language") == 1)
                image.sprite = WriteRussian1;
            else
                image.sprite = WriteEnglish1;
        }
        if (gameObject.GetComponent<PlayFreeMode>().Mode == 1)
        {
            if (PlayerPrefs.GetInt("Language") == 1)
                image.sprite = WriteRussian2;
            else
                image.sprite = WriteEnglish2;
        }
        if (gameObject.GetComponent<PlayFreeMode>().Mode == 3)
        {
            if (PlayerPrefs.GetInt("Language") == 1)
                image.sprite = WriteRussian3;
            else
                image.sprite = WriteEnglish3;
        }
    }
}
