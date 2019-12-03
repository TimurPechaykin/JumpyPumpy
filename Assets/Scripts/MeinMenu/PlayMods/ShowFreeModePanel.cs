using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowFreeModePanel : MonoBehaviour
{
    public GameObject PanelPlayfree;
    public Sprite PanelFree;

    public void Onclick()
    {
        PanelPlayfree.GetComponent<Image>().sprite = PanelFree;
        PanelPlayfree.GetComponent<PlayFreeMode>().Mode = 1;
        PanelPlayfree.SetActive(true);
    } 
}
