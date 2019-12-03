using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainingMod3 : MonoBehaviour
{
    public GameObject Heart;
    public GameObject PilaTrigger;
    public GameObject RandomballTrigger;
    public GameObject GoldBall;
    public GameObject BoomBall;
    private Vector2 places;
    public float wait;
    private bool canHill;
    void Start()
    {
        wait = 0.25f;
        StartCoroutine("Fallow");
    }


    IEnumerator Fallow()
    {
        yield return new WaitForSeconds(1);
        while (true)
        {
            yield return new WaitForSeconds(wait);
            float place = Random.Range(-8.1f, 8.1f);
            int objects = Random.Range(0, 12);
            places = new Vector2(place, 8.62f);

            if (objects == 1 || objects == 2 || objects == 3 || objects == 4)
            {
                Instantiate(PilaTrigger, places, Quaternion.identity);
            }

            else if (objects == 5)
            {
                if (canHill == true)
                {
                    Instantiate(Heart, places, Quaternion.identity);
                    StartCoroutine("canhill");
                }
            }
            
            else if (objects == 8 || objects == 9)
            {
                Instantiate(RandomballTrigger, places, Quaternion.identity);
            }
            else  if(objects == 10 )
            {
                Instantiate(BoomBall, places, Quaternion.identity);
            }
            else
            {
                Instantiate(GoldBall, places, Quaternion.identity);
            }

        }

    }
    IEnumerator canhill()
    {
        canHill = false;
        yield return new WaitForSeconds(5);
        canHill = true;
    }
}
