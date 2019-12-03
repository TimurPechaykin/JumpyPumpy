using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Potion3use : MonoBehaviour
{
    public Text _Potion3;
    private bool busy;
    private AudioSource audios;
    [SerializeField] TimeCourutine TC;

    private void Start()
    {
        TC = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<TimeCourutine>();
        audios = GetComponent<AudioSource>();
        _Potion3.text = PlayerPrefs.GetInt("Potion3").ToString();
        busy = false;
    }
    
    public void OnClickEnter()
    {
        if (PlayerPrefs.GetInt("Potion3") > 0)
        {
            if (busy == false)
            {
                StartCoroutine("Potion3");
                TC.StopAllCoroutines();
                TC.StartCoroutine("FastTime");
            }
        }
    }
    IEnumerator Potion3()
    {
        audios.Play();
        busy = true;
        PlayerPrefs.SetInt("Potion3", PlayerPrefs.GetInt("Potion3") - 1);
        _Potion3.text = PlayerPrefs.GetInt("Potion3").ToString();
        yield return new WaitForSeconds(7);
        busy = false;
    }
}
