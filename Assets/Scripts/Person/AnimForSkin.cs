using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimForSkin : MonoBehaviour
{
    private Animator animator;
    private BoxCollider2D boxCol;

    void Awake()
    {
        boxCol = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
        if (PlayerPrefs.GetInt("Skin") == 0)
        {
            animator.SetInteger("RunAnim", 1);
            boxCol.offset = new Vector2(-0.01034522f, -0.08756459f);
            boxCol.size = new Vector2(2.628978f, 4.799596f);
        }
        if (PlayerPrefs.GetInt("Skin") == 1)
        {
            animator.SetInteger("RunAnim", 2);
            boxCol.offset = new Vector2(0.007252455f, -0.3747649f);
            boxCol.size = new Vector2(2.62665f, 4.679114f);
        }
        if (PlayerPrefs.GetInt("Skin") == 2)
        {
            animator.SetInteger("RunAnim", 3);
            boxCol.offset = new Vector2(0.003430367f, -0.1901159f);
            boxCol.size = new Vector2(2.619006f, 4.384365f);
        }
        if (PlayerPrefs.GetInt("Skin") == 3)
        {
            animator.SetInteger("RunAnim", 4);
            boxCol.offset = new Vector2(0.1329861f, 0.007415295f);
            boxCol.size = new Vector2(2.609196f, 4.841916f);
        }

    }

}
