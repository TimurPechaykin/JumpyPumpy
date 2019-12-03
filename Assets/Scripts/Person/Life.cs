using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Monetization;

public class Life : MonoBehaviour
{
    // Monetization
    private string gameId = "3348235";

    //Life
    public int life;
    private GameObject life1;
    private GameObject life2;
    private GameObject life3;
    private SpriteRenderer lifes1;
    private SpriteRenderer lifes2;
    private SpriteRenderer lifes3;

    //Audio
    public AudioSource GoldUp;
    public AudioSource GodPotion;
    public AudioSource HealthPotion;
    public AudioSource Hit;
    public AudioSource Coll;

    //MainHero
    private SpriteRenderer Maincharacter;

    //Other
    public bool Gamemode;
    private int money;
    private bool addmoneyheart;
    public Text MoneyHeart;
    public bool lifeplus;
    private Color ColorPlayer;
    public Time3Mod t3M;
    public Wood woodScr;
    public Ttime time1;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        ColorPlayer = gameObject.GetComponent<SpriteRenderer>().color;
        addmoneyheart = true;
        Gamemode = false;
        Maincharacter = gameObject.GetComponent<SpriteRenderer>();
        life = 1;
        life1 = GameObject.Find("Life1");
        life2 = GameObject.Find("Life2");
        life3 = GameObject.Find("Life3");
        lifes1 = life1.GetComponent<SpriteRenderer>();
        lifes2 = life2.GetComponent<SpriteRenderer>();
        lifes3 = life3.GetComponent<SpriteRenderer>();
        lifes1.color = new Color(1f, 1f, 1f, 1f);
        lifes2.color = new Color(1f, 1f, 1f, 0f);
        lifes3.color = new Color(1f, 1f, 1f, 0f);
        if (Monetization.isSupported)
        {
            Monetization.Initialize(gameId, false);
        }
    }
    
    public void LifePlusPotion()
    {
        if(addmoneyheart == true)
        {
            addmoneyheart = false;
        }
        if (life < 3)
        {
            PlayerPrefs.SetInt("Potion2", PlayerPrefs.GetInt("Potion2") - 1);
            HealthPotion.Play();
            life++;
        }
        if (life >= 3)
        {
            life = 3;
        }
        if (life == 3)
        {
            lifes3.color = new Color(1f, 1f, 1f, 1);
            lifes2.color = new Color(1f, 1f, 1f, 1);
        }
        if (life == 2)
        {
            lifes3.color = new Color(1f, 1f, 1f, 0);
            lifes2.color = new Color(1f, 1f, 1f, 1);
        }
        if (life == 1)
        {
            lifes1.color = new Color(1f, 1f, 1f, 1f);
            lifes2.color = new Color(1f, 1f, 1f, 0);
            lifes3.color = new Color(1f, 1f, 1f, 0);
        }
    }

    private void Update()
    {
        if (life == 3)
        {
            lifes3.color = new Color(1f, 1f, 1f, 1);
            lifes2.color = new Color(1f, 1f, 1f, 1);
        }
        else if (life == 2)
        {
            lifes3.color = new Color(1f, 1f, 1f, 0);
            lifes2.color = new Color(1f, 1f, 1f, 1);
        }
        else if (life == 1)
        {
            lifes1.color = new Color(1f, 1f, 1f, 1f);
            lifes2.color = new Color(1f, 1f, 1f, 0);
            lifes3.color = new Color(1f, 1f, 1f, 0);
        }
        else if (life <= 0)
        {
            if (Monetization.isInitialized)
                PlayerPrefs.SetInt("Die", PlayerPrefs.GetInt("Die") + 1);
            if (gameObject.GetComponent<Player>().Mod == 1)
            {
                SceneManager.LoadScene("Balance");
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
            if (gameObject.GetComponent<Player>().Mod == 2)
            {
                SceneManager.LoadScene("BalanceMod");
                if (woodScr.BalanceValueNow > 25)
                {
                    if (Monetization.IsReady("video"))
                    {
                        ShowAdPlacementContent ad = Monetization.GetPlacementContent("video") as ShowAdPlacementContent;
                        if (ad != null)
                            ad.Show();
                    }
                }
            }
            if (gameObject.GetComponent<Player>().Mod == 3)
            {
                SceneManager.LoadScene("GoldMod");
                if (t3M.Moneytake > 45)
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Pila")
        {
            if (Gamemode == false)
            {
                life--;
                StartCoroutine("MinusLife");
            }
        }
        if (collision.tag == "GoldBall")
        {
            GoldUp.Play();
        }
        if (collision.tag == "Random")
        {
            Coll.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "GoldBall")
        {
            GoldUp.Play();
        }
        else if (collision.gameObject.tag == "Heart")
        {
            life++;
            HealthPotion.Play();
            if (life >= 3)
            {
                if (addmoneyheart == true)
                {
                    addmoneyheart = false;
                    PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + 300);
                    MoneyHeart.text = PlayerPrefs.GetInt("Money").ToString();
                }
                life = 3;
            }
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Pila")
        {
            if (Gamemode == false)
            {
                life--;
                StartCoroutine("MinusLife");
            }
        }
        else if (collision.gameObject.tag == "Random")
        {
            Coll.Play();
        }

    }
            
    IEnumerator MinusLife()
    {
        Gamemode = true;
        Hit.Play();
        for (int i = 5; i != 0; i--)
        {
            Maincharacter.color = new Color(1f, 1f, 1f, 0f);
            yield return new WaitForSeconds(0.2f);
            Maincharacter.color = ColorPlayer;
            yield return new WaitForSeconds(0.2f);
        }
        Gamemode = false;
    }
    
    IEnumerator GamemodePotion()
    {
        if (Gamemode == false)
        {
            PlayerPrefs.SetInt("Potion1", PlayerPrefs.GetInt("Potion1") - 1);
            Gamemode = true;
            GodPotion.Play();
            for (int i = 12; i != 0; i--)
            {
                Maincharacter.color = new Color(1f, 1f, 1f, 0f);
                yield return new WaitForSeconds(0.2f);
                Maincharacter.color = ColorPlayer;
                yield return new WaitForSeconds(0.2f);

            }
            Gamemode = false;
        }
    }
}
