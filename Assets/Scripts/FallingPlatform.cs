using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    bool isFalling = false;
    float downSpeed = 0;
    public float resetTimer = 10.0f;
    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "PlayerCapsule")
            StartCoroutine(NewPlatform());

    }

    IEnumerator NewPlatform()
    {
        isFalling = true;
        yield return new WaitForSeconds(resetTimer);
        isFalling = false;
        transform.position = initialPosition;
        downSpeed = 0;
    }

    void Update()
    {
        if (isFalling)
        {
            downSpeed += Time.deltaTime/120;
            transform.position = new Vector3(transform.position.x, transform.position.y-downSpeed, transform.position.z);

        }


    }
}
