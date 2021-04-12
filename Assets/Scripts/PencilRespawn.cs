using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PencilRespawn : MonoBehaviour
{
    private GameObject gameManager2;
    private GameObject[] objs;

    private Manager2 Manager;


    private void Start()
    {
        gameManager2 = GameObject.Find("gameManager2");
        objs = GameObject.FindGameObjectsWithTag("Coin");
        Manager = gameManager2.GetComponent<Manager2>();
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Manager.PositionPlayer();
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
