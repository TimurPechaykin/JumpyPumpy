using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject PauseClick;
    public GameObject Panelka;
    // Start is called before the first frame update
    public void Awake()
    {
        Panelka.SetActive( false);
    }

    // Update is called once per frame
    public void OnPause()
    {
        PauseClick.SetActive(false);
        Time.timeScale = 0f;
        Panelka.SetActive(true);
    }
}
