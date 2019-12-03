using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GoLeft : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public float speed;
    public Rigidbody2D rb;
    public bool  LeftNow;
    public SpriteRenderer sp;
    public bool RightNow;
    private int mod;
    public void Start()
    {
        rb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        sp = GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>();
        speed = 0;
        mod = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().Mod;
    }
    public void FixedUpdate()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }
    public void OnPointerDown(PointerEventData pointerEventData)
    {
        sp.flipX = false;
        LeftNow = true;
        if (mod == 3) 
        speed = -7;
        else
        {
            speed = -3;
        }
    }

    //Detect if clicks are no longer registering
    public void OnPointerUp(PointerEventData pointerEventData)
    {
        LeftNow = false;
        if (LeftNow == false && RightNow == false)
        {
            speed = 0;
        }
        else if (LeftNow == true && RightNow == false)
        {
            sp.flipX = false;
            if (mod == 3)
            {
                speed = -7;
            }
            else
            {
                speed = -3;
            }
        }
        else if (LeftNow == false && RightNow == true)
        {
            sp.flipX = true;
            if (mod == 3)
            {
                speed = 7;
            }
            else
            {
                speed = 3;
            }
        }
    }
    
}
