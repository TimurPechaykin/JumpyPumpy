using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModForPila : MonoBehaviour
{
    private GameObject player;
    [SerializeField] bool Pila;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if(player.GetComponent<Player>().Mod == 3)
        {
            gameObject.GetComponent<CircleCollider2D>().isTrigger = true;
            if (Pila == true)
                StartCoroutine("Rotatealways");
        }
        else
        {
            gameObject.GetComponent<CircleCollider2D>().isTrigger = false;
        }
    }
    IEnumerator Rotatealways()
    {
        int i = 0;
        while (true)
        {

            transform.rotation = Quaternion.Euler(0, 0, i);
            i++;
            yield return new WaitForSeconds(0.00001f);

        }
    }
}
