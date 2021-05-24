using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager2 : MonoBehaviour
{
    public Transform spawnPoint;
    public Transform WallRespawn;
    public GameObject player;
    public GameObject Wall;
    private GameObject[] objs;
    private GameObject[] Power;

    public void PositionPlayer()
    {
        player.transform.position = spawnPoint.position;
        player.transform.rotation = spawnPoint.rotation;
        Wall.transform.position = WallRespawn.position;
        Wall.transform.rotation = WallRespawn.rotation;
        CoinRespawn();
        RespawnPowerup();

    }

    // Start is called before the first frame update
    void Start()
    {
        objs = GameObject.FindGameObjectsWithTag("Coin");
        Power = GameObject.FindGameObjectsWithTag("PowerUp");
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
    // Update is called once per frame
    void CoinRespawn()
    {
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
