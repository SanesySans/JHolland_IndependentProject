using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerCoinScript : MonoBehaviour
{
    public AudioSource coinCollect;

    // Start is called before the first frame update
    void Start()
    {
        
    }



    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gameObject.SetActive(false);
           
            coinCollect.Play();
        }

    }


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
    }
}
