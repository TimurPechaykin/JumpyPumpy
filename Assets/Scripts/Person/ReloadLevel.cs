using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadLevel : MonoBehaviour
{
    public GameObject ButtonReload;
    private float btnrld;
    // Start is called before the first frame update
    private void Awake()
    {
        btnrld = ButtonReload.transform.position.y;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(btnrld != ButtonReload.transform.position.y)
        {
            SceneManager.LoadScene("Balance", LoadSceneMode.Single);
        }
    }
}
