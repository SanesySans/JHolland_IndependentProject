using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerRespawn : MonoBehaviour
{
    public GameManager gameManager;

    private GameObject[] objs;
    
    private GameObject[] Power;


    private void Start()
    {
        objs = GameObject.FindGameObjectsWithTag("Coin");
        Power = GameObject.FindGameObjectsWithTag("PowerUp");
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            DestroyEnemy();
            RespawnPowerup();
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