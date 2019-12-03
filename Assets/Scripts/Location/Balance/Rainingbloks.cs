using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rainingbloks : MonoBehaviour
{
    public GameObject Heart;
    public GameObject Pila;
    public GameObject Sphere;
    public GameObject BoomBall;
    public GameObject Randomball;
    public GameObject GoldBall;
    public Transform[] place;
    
    void Start()
    {
        StartCoroutine("Fallow");
    }


    IEnumerator Fallow()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            int places = Random.Range(0, place.Length);
            int objects = Random.Range(0, 11);
            
            if (objects == 1)
            {
                Instantiate(Heart, place[places].transform.position, Quaternion.identity);


            }
            else if (objects == 2 || objects == 3)
            {
                int placesphere = Random.Range(0, 2);
                Instantiate(Sphere, place[placesphere].transform.position, Quaternion.identity);
            }
            else if (objects == 4 || objects == 5)
            {
                Instantiate(Randomball, place[2].transform.position, Quaternion.identity);
            }
            else if (objects == 7)
            {

                Instantiate(GoldBall, place[2].transform.position, Quaternion.identity);
            }
            else if (objects == 8 || objects == 9)
            {

                Instantiate(Pila, place[places].transform.position, Quaternion.identity);
            }
            else
            {
                Instantiate(BoomBall, place[places].transform.position, Quaternion.identity);
            }
            
        }
            
    }

}
