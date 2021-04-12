using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimScript : MonoBehaviour
{

    public Animator AnimAlmond;

    // Start is called before the first frame update
    void Start()
    {
        AnimAlmond = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            AnimAlmond.SetBool("Moving", true);
        }
        else
        {
            AnimAlmond.SetBool("Moving", false);
        }
    }
}
