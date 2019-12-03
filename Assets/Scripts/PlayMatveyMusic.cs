using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMatveyMusic : MonoBehaviour
{
    private static PlayMatveyMusic music;

    void Awake()
    {
        if (music != null)
        {
            Destroy(gameObject);
        }
        else
        {
            music = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    
}
