using UnityEngine;

public class ClickOnMagazine : MonoBehaviour
{
    public GameObject Menu;
    public GameObject PlayMenu;
    public GameObject PotionMagazine;
    public GameObject BGShopbtn;
    public GameObject BGShop;
    public GameObject Magazine;
    public GameObject PotionShopBtn;
    public GameObject SkinBtn;
    public GameObject SkinShop;

    public void OnClickMagazine()
    {
        Menu.SetActive(false);
        PlayMenu.SetActive(false);
        BGShopbtn.SetActive(true);
        PotionShopBtn.SetActive(true);
        BGShop.SetActive(false);
        PotionMagazine.SetActive(false);
        Magazine.SetActive(true);
        SkinBtn.SetActive(true);
        SkinShop.SetActive(false);
    }
}
