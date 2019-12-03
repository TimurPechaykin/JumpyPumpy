using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowBG : MonoBehaviour
{
    public GameObject SkinSelect;
    public GameObject BGSelect;
    public void Showbg()
    {
        SkinSelect.SetActive(false);

        BGSelect.SetActive(true);
    }
    public void ShowSkin()
    {

        SkinSelect.SetActive(true);
        BGSelect.SetActive(false);
    }
}
