using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagazineBtn : MonoBehaviour
{
    public GameObject Mainmenu;
    public GameObject Magazine;
    public GameObject PotionMagazine;
    public void OnclickMagazine()
    {
        Mainmenu.SetActive(false);
        Magazine.SetActive(true);
        PotionMagazine.SetActive(false);
    }
}
