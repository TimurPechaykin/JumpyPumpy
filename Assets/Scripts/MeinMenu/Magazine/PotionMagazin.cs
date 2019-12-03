using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionMagazin : MonoBehaviour
{
    public GameObject BGSelectbtn;
    public GameObject SkinShopbtn;
    public GameObject PotionMagazinebtn;
    public GameObject PotionBuy;
    public GameObject BGShop;
    public GameObject SkinShop;

    public void OnСlickPotionMagazine()
    { 
        gameObject.SetActive(false);
        BGSelectbtn.SetActive(false);
        SkinShopbtn.SetActive(false);
        PotionBuy.SetActive(true);
    }
    public void OnСlickBGMagazine()
    {
        PotionMagazinebtn.SetActive(false);
        BGSelectbtn.SetActive(false);
        SkinShopbtn.SetActive(false);
        BGShop.SetActive(true);
    }
    public void OnСlickShopMagazine()
    {
        PotionMagazinebtn.SetActive(false);
        BGSelectbtn.SetActive(false);
        SkinShopbtn.SetActive(false);
        SkinShop.SetActive(true);
    }
}
