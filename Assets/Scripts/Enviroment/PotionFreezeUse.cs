using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotionFreezeUse : MonoBehaviour
{
    public Text _Potion4;
    private bool busy;
    private AudioSource audios;
    [SerializeField] TimeCourutine TC;

    private void Start()
    {
        TC = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<TimeCourutine>();
        audios = GetComponent<AudioSource>();
        busy = false;
        _Potion4.text = PlayerPrefs.GetInt("Potion4").ToString();
    }

    public void OnClickEnter()
    {
        if (PlayerPrefs.GetInt("Potion4") > 0)
        {
            if (busy == false)
            {
                StartCoroutine("Potion4");
                TC.StopAllCoroutines();
                TC.StartCoroutine("FreezeTime");
            }
        }
    }
    IEnumerator Potion4()
    {
        busy = true;
        audios.Play();
        PlayerPrefs.SetInt("Potion4", PlayerPrefs.GetInt("Potion4") - 1);
        _Potion4.text = PlayerPrefs.GetInt("Potion4").ToString();
        yield return new WaitForSeconds(3.75f);
        busy = false;
    }
}