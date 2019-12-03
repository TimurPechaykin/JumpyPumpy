using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApPause : MonoBehaviour
{
    public GameObject PauseClick;
    public GameObject Panelka;


    // Update is called once per frame
    public void OnPause()
    {
        PauseClick.SetActive(true);
        Time.timeScale = 1f;
        Panelka.SetActive(false);
    }
}
