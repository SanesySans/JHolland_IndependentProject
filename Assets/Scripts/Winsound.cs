using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winsound : MonoBehaviour
{
    public AudioSource EndSound;



    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            EndSound.Play();
        }
    }
}