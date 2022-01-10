using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject creditCanvas;

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Credit()
    {
        MainMenu.SetActive(false);
        creditCanvas.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            creditCanvas.SetActive(false);
            MainMenu.SetActive(true);
        }
    }
}
