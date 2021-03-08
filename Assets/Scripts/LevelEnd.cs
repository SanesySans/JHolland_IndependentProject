using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelEnd : MonoBehaviour
{
    public GameObject levelFinishUI;
    public GameManager gameManager;
    private GameObject[] objs;
    public GameObject endScoreText;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            levelFinishUI.SetActive(true);
           endScoreText.GetComponent<Text>().text = "Score: " + ScoringSystem.theScore;
            Time.timeScale = 0f;
        }
    }



    public void RestartLevel()
    {
        Time.timeScale = 1f;
        levelFinishUI.SetActive(false);
    }
}
