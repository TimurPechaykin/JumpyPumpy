using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BombBoom : MonoBehaviour
{
    private GameObject Player;
    public Sprite SpriteBoom;
    private Animator animator;
    public CircleCollider2D coliderEffector;
    private SpriteRenderer spriterendererBoom;
    private SpriteRenderer SpriteChange;
    private Rigidbody2D rb;
    private AudioSource BoomSound;
    private int i;
    private bool SoundCan;
    private void Start()
    {
        SoundCan = true;
        SpriteChange = GetComponent<SpriteRenderer>();
        BoomSound = GetComponent<AudioSource>();
        StartCoroutine("Rotatealways");
        i = 0;
        rb = gameObject.GetComponent<Rigidbody2D>();
        spriterendererBoom = gameObject.GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        Player = GameObject.FindGameObjectWithTag("Player");
        if(Player.GetComponent<Player>().Mod == 3)
        {
            gameObject.GetComponent<CircleCollider2D>().isTrigger = true;
        }
        else
        {
            gameObject.GetComponent<CircleCollider2D>().isTrigger = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Player.GetComponent<Player>().Mod == 3)
        {
            if (collision.tag == "Player")
            {
                
                StartCoroutine("BoomEffect");
                if (Player.GetComponent<Life>().Gamemode == false)
                {
                    Player.GetComponent<Life>().life -= 1;
                    Player.GetComponent<Life>().StartCoroutine("MinusLife");
                }
            }
            if(collision.tag == "Ground")
            {
                StartCoroutine("BoomEffect");
            }
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine("BoomEffect");
            if (Player.GetComponent<Life>().Gamemode == false)
                {
                    Player.GetComponent<Life>().life -= 1;
                    Player.GetComponent<Life>().StartCoroutine("MinusLife");
                }
        }
        if (collision.gameObject.tag == "Ground")
        {
            StartCoroutine("BoomEffect");
        }
    }
    IEnumerator BoomEffect()
    {
        if(SoundCan == true)
            BoomSound.Play();
        SoundCan = false;
        SpriteChange.sprite = SpriteBoom;
        rb.constraints = RigidbodyConstraints2D.FreezePosition;
        coliderEffector.usedByEffector = true;
        float i = 0;
        for (; i <= 1; i += 0.1f)
        {
            spriterendererBoom.color = new Color(1, 1, 1, i);
            yield return new WaitForSeconds(0.01f);
        }
        for (; i >= 0; i -= 0.1f)
        {
            spriterendererBoom.color = new Color(1, 1, 1, i);
            yield return new WaitForSeconds(0.01f);
        }
        coliderEffector.usedByEffector =false;
        SoundCan = true;
        Destroy(gameObject);
    }
    IEnumerator Rotatealways()
    {
        while (true)
        {
            
            transform.rotation = Quaternion.Euler(0,0,i);
            i++;
            yield return new WaitForSeconds(0.00001f);
               
        }
    }
}
