using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
            ScoringSystem.theScore = 0;
            Time.timeScale = 0f;
        }
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("SecondLevel");
    }

    public void PreviousLevel()
    {
        SceneManager.LoadScene("FirstLevel");
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;
        levelFinishUI.SetActive(false);
    }
}
