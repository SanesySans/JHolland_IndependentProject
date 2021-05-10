using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PencilRespawn : MonoBehaviour
{
    private GameObject gameManager2;
    private GameObject[] objs;

    private GameObject[] Power;

    private Manager2 Manager;


    private void Start()
    {
        gameManager2 = GameObject.Find("gameManager2");
        objs = GameObject.FindGameObjectsWithTag("Coin");
        Manager = gameManager2.GetComponent<Manager2>();
        Power = GameObject.FindGameObjectsWithTag("PowerUp");
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            DestroyEnemy();
            Manager.PositionPlayer();
            RespawnPowerup();
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

    void RespawnPowerup()
    {
        foreach (GameObject Powerup in Power)
        {
            if (Powerup.CompareTag("PowerUp"))
            {
                Powerup.SetActive(true);
            }

        }
    }

    void DestroyEnemy()
    {
        var enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (var enemy in enemies)
        {
            Destroy(enemy);
        }
    }
}
