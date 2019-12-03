using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Monetization;

public class Dead : MonoBehaviour
{
    private GameObject Player;
    private int mod;
    public Wood wood;
    public Ttime time1;
    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        mod = Player.GetComponent<Player>().Mod;
        if (Monetization.isSupported)
        {
            Monetization.Initialize("3348235", false);
        }
    }
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (Monetization.isInitialized)
                PlayerPrefs.SetInt("Die", PlayerPrefs.GetInt("Die") + 1);
            if (mod == 1)
            {

                SceneManager.LoadScene("Balance");
                Time.timeScale = 1;
                if (time1.sec > 40)
                {
                    if (Monetization.IsReady("video"))
                    {
                        ShowAdPlacementContent ad = Monetization.GetPlacementContent("video") as ShowAdPlacementContent;
                        if (ad != null)
                            ad.Show();
                    }
                }
            }
            if (mod == 2)
            {

                SceneManager.LoadScene("BalanceMod");
                Time.timeScale = 1;
                if (wood.BalanceValueNow > 20)
                {
                    if (Monetization.IsReady("video"))
                    {
                        ShowAdPlacementContent ad = Monetization.GetPlacementContent("video") as ShowAdPlacementContent;
                        if (ad != null)
                            ad.Show();
                    }
                }

            }
            if (PlayerPrefs.GetInt("Die") >= 10)
            {
                if (Monetization.IsReady("video"))
                {
                    ShowAdCallbacks options = new ShowAdCallbacks();
                    options.finishCallback = HandleShowResult;
                    ShowAdPlacementContent ad = Monetization.GetPlacementContent("video") as ShowAdPlacementContent;
                    ad.Show(options);
                }
            }

        }
        else
            Destroy(collision.gameObject);
    }
    void HandleShowResult(ShowResult result)
    {
        if (result == ShowResult.Finished)
        {
            PlayerPrefs.SetInt("Die", 0);
        }
        else if (result == ShowResult.Skipped)
        {
            PlayerPrefs.SetInt("Die", 0);
        }
        else if (result == ShowResult.Failed)
        {
            PlayerPrefs.SetInt("Die", 10);
        }
    }

}
