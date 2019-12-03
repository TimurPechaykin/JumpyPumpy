using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitMagazine : MonoBehaviour
{
    public GameObject Mainmenu;
    public GameObject Magazine;
    public void OnclickExitMagazine()
    {
        Mainmenu.SetActive(true);
        Magazine.SetActive(false);
    }
}
