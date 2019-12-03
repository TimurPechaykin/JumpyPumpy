using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgOnMods : MonoBehaviour
{
    
    public GameObject BGHeights;
    public GameObject BGVulcan;
    public GameObject BGSea;
    public GameObject Cloud1;
    public GameObject Cloud2;
    private void Awake()
    {
        if (PlayerPrefs.GetInt("BG") == 0)
        {
            BGHeights.SetActive(true);
            BGVulcan.SetActive(false);
            BGSea.SetActive(false);
            Cloud1.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 102);
            Cloud2.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 102);
            GameObject.FindGameObjectWithTag("MainCamera").
                GetComponent<Camera>().backgroundColor = new Color32(48,172,206,0);
        }
        else if (PlayerPrefs.GetInt("BG") == 1)
        {
            BGHeights.SetActive(false);
            BGVulcan.SetActive(false);
            BGSea.SetActive(true);
            Cloud1.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 102);
            Cloud2.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 102);
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().backgroundColor = new Color32(48,173,207,0);
        }
        else if (PlayerPrefs.GetInt("BG") == 2)
        {
            BGHeights.SetActive(false);
            BGSea.SetActive(false);
            BGVulcan.SetActive(true);
            Cloud1.GetComponent<SpriteRenderer>().color = new Color32(255,40,40,102);
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().backgroundColor = new Color32(132,32,19,0);
            Cloud2.GetComponent<SpriteRenderer>().color = new Color32(255, 40, 40, 102);
            GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>().color
            = new Color32(238, 131, 131, 255);
        }
    }
}
