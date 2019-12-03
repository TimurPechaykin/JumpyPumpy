using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloudrun : MonoBehaviour
{
    public GameObject target;
    private float speed = 0.8f;
    
    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        if(transform.position.x>12)
        {

            transform.position = new Vector2(-10, transform.position.y);
        }
    }
}
