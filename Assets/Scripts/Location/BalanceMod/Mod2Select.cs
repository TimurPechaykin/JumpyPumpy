using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mod2Select : MonoBehaviour
{
    private GameObject player;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<Player>().Mod = 2;
    }
}
