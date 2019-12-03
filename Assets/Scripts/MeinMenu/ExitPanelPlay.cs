using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitPanelPlay : MonoBehaviour
{
    public GameObject Panelplay;
    public void ClickExit()
    {
        Panelplay.SetActive(false);
    }
}
