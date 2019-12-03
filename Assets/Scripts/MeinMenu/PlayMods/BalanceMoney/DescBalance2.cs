using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DescBalance2 : MonoBehaviour
{
    public GameObject PanelPlayfree;
    public Sprite PanelFreeSprite;

    public void Onclick()
    {
        PanelPlayfree.GetComponent<Image>().sprite = PanelFreeSprite;
        PanelPlayfree.GetComponent<PlayFreeMode>().Mode = 2;
        PanelPlayfree.SetActive(true);
    }
}
