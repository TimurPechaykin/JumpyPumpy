using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitPotionMagazine : MonoBehaviour
{
    public GameObject PotionMagazine;
    public GameObject Magazine;
    public GameObject BtnExitMagazine;
    public GameObject BtnBG;
    public void OnclickExitMagazine()
    {
        PotionMagazine.SetActive(false);
        Magazine.SetActive(true);
        BtnExitMagazine.SetActive(true);
        BtnBG.SetActive(true);
    }
}
