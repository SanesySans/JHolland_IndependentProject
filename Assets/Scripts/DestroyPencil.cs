using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPencil : MonoBehaviour
{
    private float LeftSide = -20.0f;
    private float RightSide = 20.0f;


    void Update()
    {
        if (transform.position.z > RightSide)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < LeftSide)
        {
            Destroy(gameObject);;
        }
    }

}
