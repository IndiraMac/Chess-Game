using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuiteGame : MonoBehaviour
{
    public GameObject quiteGameCanvas;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            quiteGameCanvas.SetActive(true);
        }
    }

    public void Yes()
    {
        Application.Quit();
    }

    public void No()
    {
        quiteGameCanvas.SetActive(false);
    }
}
