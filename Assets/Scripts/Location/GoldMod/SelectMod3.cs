using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectMod3 : MonoBehaviour
{
    private GameObject player;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<Player>().Mod = 3;
    }
}
