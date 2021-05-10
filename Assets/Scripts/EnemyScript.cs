using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    public int AttackTrigger2;
    public GameObject Player;
    public int MoveSpeed = 8;
    public int MaxDist = 10;
    public int MinDist = 5;

    void Start()
    {
        Player = GameObject.FindWithTag("Player");
    }

    void Update()
    {

        transform.LookAt(Player.transform);
        

        if (Vector3.Distance(transform.position, Player.transform.position) <= MaxDist)
        {
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
            if (Vector3.Distance(transform.position, Player.transform.position) <= MinDist);
            
        }
    
    }
}