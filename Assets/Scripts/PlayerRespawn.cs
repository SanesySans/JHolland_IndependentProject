using UnityEngine;
using System.Collections;

public class PlayerRespawn : MonoBehaviour
{
    public GameManager gameManager;

    private GameObject[] objs;



    private void Start()
    {
        objs = GameObject.FindGameObjectsWithTag("Coin");

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gameManager.PositionPlayer();
            GameObject.Find("Death").GetComponent<ParticleSystem>().Play();
            foreach (GameObject obj in objs)
            {
                if (obj.CompareTag("Coin"))
                {
                    obj.SetActive(true);
                    ScoringSystem.theScore = 0;
                }
            }
        }
            
    }
}