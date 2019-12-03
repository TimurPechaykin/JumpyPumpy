using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainingHardBlock : MonoBehaviour
{
    private Vector2 posBall;
    public GameObject LightBall;
    private void Update()
    {
        if(GameObject.FindGameObjectWithTag("LightBall") == null)
        {
            float randomplace1 = Random.Range(-2.5f, 2.5f);
            posBall = new Vector2(randomplace1, 8.62f);
            Instantiate(LightBall, posBall, Quaternion.identity);
            float randomplace2 = Random.Range(-2.5f, 2.5f);
            posBall = new Vector2(randomplace2, 8.62f);
            Instantiate(LightBall, posBall, Quaternion.identity);
        } 
    }
    
}
