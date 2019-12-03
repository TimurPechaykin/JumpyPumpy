using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VulcanBalls : MonoBehaviour
{
    private float posBall;
    private Rigidbody2D rb;
    [SerializeField]
    private int h;
    [SerializeField]
    private bool UpGo;
    private float speed =2;
    private Vector2 vectorUp;
    private Vector2 vectorDown;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        posBall = transform.position.y;
        vectorUp = new Vector2(transform.position.x, transform.position.y + Random.RandomRange(0.1f,0.7f));
        vectorDown = new Vector2(transform.position.x, transform.position.y - Random.RandomRange(0.1f, 0.7f));
        UpGo = true;
    }
    private void FixedUpdate()
    {
        if (UpGo == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, vectorUp, speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, vectorDown, speed * Time.deltaTime);
        }
        if (Vector2.Distance(transform.position, vectorUp) < 0.01f)
            UpGo = false;
        else if (Vector2.Distance(transform.position, vectorDown) < 0.01f)
            UpGo = true;
    }
}
