using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeAlRed : MonoBehaviour
{
    void Start()
    {
        if (PlayerPrefs.GetInt("BG") == 2)
            gameObject.GetComponent<SpriteRenderer>().color = new Color32(255,110,110,255);
    }
}
