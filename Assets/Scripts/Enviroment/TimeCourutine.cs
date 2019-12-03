using System.Collections;
using UnityEngine;

public class TimeCourutine : MonoBehaviour
{
    IEnumerator FreezeTime()
    {
        Time.timeScale = 0.7f;
        yield return new WaitForSeconds(3.75f);
        Time.timeScale = 1f;
    }
    IEnumerator FastTime()
    {
        Time.timeScale = 1.4f;
        yield return new WaitForSeconds(7f);
        Time.timeScale = 1f;
    } 
}
