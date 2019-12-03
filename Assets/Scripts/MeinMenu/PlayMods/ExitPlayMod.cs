using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitPlayMod : MonoBehaviour
{
    public GameObject PlayMods;
    public GameObject MainMenu;
    public void OnClickExit()
    {
        PlayMods.SetActive(false);
        MainMenu.SetActive(true);
    }
}
