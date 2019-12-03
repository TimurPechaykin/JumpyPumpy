using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour
{
    [SerializeField] private BombBoom bomb;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
            bomb.StartCoroutine("BoomEffect");
    }
}
