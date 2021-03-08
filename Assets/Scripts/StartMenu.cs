using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    public static bool GamePaused = true;

    public GameObject startMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (GamePaused)
        {
            Start_Menu();
        }

        else
        {
            StartGame();
        }
    }

    public void StartGame ()
    {
        startMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }

    

    void Start_Menu ()
    {
        startMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }
}
