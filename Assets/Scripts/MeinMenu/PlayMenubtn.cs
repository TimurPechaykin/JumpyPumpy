using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMenubtn : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Magazine;
    public GameObject PlayModes;
    public GameObject ModPanel;
    public GameObject Exit;

    public void OnClickPlay()
    {
        
        Menu.SetActive(false);
        Magazine.SetActive(false);
        PlayModes.SetActive(true);
        ModPanel.SetActive(false);
        Exit.SetActive(true);
    }
    public void OnClickPlaytrue()
    {
        Menu.SetActive(false);
        Magazine.SetActive(false);
        PlayModes.SetActive(true);
        ModPanel.SetActive(false);
    }
    public void OnExit()
    {
        Application.Quit();
        
    }
}
