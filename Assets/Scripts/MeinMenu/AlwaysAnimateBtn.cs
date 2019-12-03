using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlwaysAnimateBtn : MonoBehaviour
{
    private Animator animator;
    private RectTransform rect;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        rect = GetComponent<RectTransform>();
        if (PlayerPrefs.GetInt("Skin") == 0)
        {
            rect.sizeDelta = new Vector2(100, 180);
            animator.SetInteger("RunAnim", 1);
        }
        if (PlayerPrefs.GetInt("Skin") == 1)
        {
            rect.sizeDelta = new Vector2(100, 199.25f);
            animator.SetInteger("RunAnim", 2);
        }
        if (PlayerPrefs.GetInt("Skin") == 2)
        {
            animator.SetInteger("RunAnim", 3);
            rect.sizeDelta = new Vector2(100, 180);
        }
        if (PlayerPrefs.GetInt("Skin") == 3)
        {
            animator.SetInteger("RunAnim", 4);
            rect.sizeDelta = new Vector2(110, 180);
        }
    }
    private void Update()
    {
        if (PlayerPrefs.GetInt("Skin") == 0)
        {
            rect.sizeDelta = new Vector2(100, 180);
            animator.SetInteger("RunAnim", 1);
        }
        if (PlayerPrefs.GetInt("Skin") == 1)
        {
            rect.sizeDelta = new Vector2(100, 199.25f);
            animator.SetInteger("RunAnim", 2);
        }
        if (PlayerPrefs.GetInt("Skin") == 2)
        {
            animator.SetInteger("RunAnim", 3);
            rect.sizeDelta = new Vector2(100, 180);
        }
        if (PlayerPrefs.GetInt("Skin") == 3)
        {
            animator.SetInteger("RunAnim", 4);
            rect.sizeDelta = new Vector2(110, 180);
        }
    }
}
