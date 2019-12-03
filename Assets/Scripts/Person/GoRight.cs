using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GoRight : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GoLeft gl;
    private int mod;

    void Start()
    {
        mod = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().Mod;
    }
    public void OnPointerDown(PointerEventData pointerEventData)
    {
        gl.sp.flipX = true;
        gl.RightNow = true;
        if (mod == 3)
        {
            gl.speed = 7;
        }
        else
        {
            gl.speed = 3;
        }

    }

    //Detect if clicks are no longer registering
    public void OnPointerUp(PointerEventData pointerEventData)
    {
        gl.RightNow = false;
        if (gl.LeftNow == false && gl.RightNow == false)

            gl.speed = 0;

        else if (gl.LeftNow == true && gl.RightNow == false)
        {
            gl.sp.flipX = false;
            if (mod == 3)
            {
                gl.speed = -7;
            }
            else
            {
                gl.speed = -3;
            }
        }

        else if (gl.LeftNow == false && gl.RightNow == true)
        {
            gl.sp.flipX = true;
            if (mod == 3)
            {
                gl.speed = 7;
            }
            else
            {
                gl.speed = 3;
            }
        }
    }
}