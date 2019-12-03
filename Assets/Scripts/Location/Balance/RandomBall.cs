using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBall : MonoBehaviour
{
    public GameObject Heart;
    public GameObject Pila;
    public GameObject LongerWood;
    public GameObject HardBall;
    private GameObject PlaceLeft;
    private GameObject PlaceMidle;
    private GameObject PlaceRight;
    private Vector2 posBall;
    [SerializeField] TimeCourutine TC;
    private void Start()
    {
        TC = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<TimeCourutine>();
        PlaceLeft = GameObject.Find("PlaceLeft");
        PlaceMidle = GameObject.Find("PlaceMidlle");
        PlaceRight = GameObject.Find("PlaceRight");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            int random = Random.Range(0, 12);
            if (random == 1 || random == 2)
            {
                Instantiate(Pila, PlaceMidle.transform.position, Quaternion.identity);
            }
            if (random == 3)
            {
                Instantiate(Pila, PlaceLeft.transform.position, Quaternion.identity);
                Instantiate(Pila, PlaceMidle.transform.position, Quaternion.identity);
                Instantiate(Pila, PlaceRight.transform.position, Quaternion.identity);
            }
            if (random == 4 || random == 5)
            {
                TC.StopAllCoroutines();
                TC.StartCoroutine("FastTime");
            }
            if (random == 6)
            {
                TC.StopAllCoroutines();
                TC.StartCoroutine("FreezeTime");
            }
            if (random == 7 || random == 8)
            {
                if (collision.GetComponent<Player>().Mod == 1 || collision.GetComponent<Player>().Mod == 2)
                {
                    Instantiate(HardBall, PlaceLeft.transform.position, Quaternion.identity);
                    Instantiate(HardBall, PlaceRight.transform.position, Quaternion.identity);
                }
                else
                {
                    Instantiate(Pila, PlaceLeft.transform.position, Quaternion.identity);
                    Instantiate(Pila, PlaceMidle.transform.position, Quaternion.identity);
                    Instantiate(Pila, PlaceRight.transform.position, Quaternion.identity);
                }
            }
            if (random == 9 || random == 10)
            {
                Instantiate(Heart, PlaceMidle.transform.position, Quaternion.identity);
            }
            if (random == 11)
            {
                Instantiate(LongerWood, PlaceMidle.transform.position, Quaternion.identity);
            }
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            float RandomPlace = Random.Range(-4.2f, 4.2f);
            posBall = new Vector2(RandomPlace, 8.62f);
            int random = Random.Range(0, 12);
            Debug.Log(random);
            if (random == 1 || random == 2 || random == 0)
            {
                Instantiate(Pila, PlaceMidle.transform.position, Quaternion.identity);
            }
            if (random == 3)
            {
                Instantiate(Pila, PlaceLeft.transform.position, Quaternion.identity);
                Instantiate(Pila, PlaceMidle.transform.position, Quaternion.identity);
                Instantiate(Pila, PlaceRight.transform.position, Quaternion.identity);
            }
            if (random == 4 || random == 5)
            {
                TC.StopAllCoroutines();
                TC.StartCoroutine("FastTime");
            }
            if (random == 6)
            {
                TC.StopAllCoroutines();
                TC.StartCoroutine("FreezeTime");
            }
            if (random == 7 || random == 8)
            {

                Instantiate(HardBall, PlaceLeft.transform.position, Quaternion.identity);
                Instantiate(HardBall, PlaceRight.transform.position, Quaternion.identity);

            }
            if (random == 9 || random == 10)
            {
                Instantiate(Heart, PlaceMidle.transform.position, Quaternion.identity);
            }
            if (random == 11)
            {
                Instantiate(LongerWood, posBall, Quaternion.identity);
            }
            Destroy(gameObject);
        }
    }

    
}
