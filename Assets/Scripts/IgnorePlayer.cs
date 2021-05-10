using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnorePlayer : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public Transform PlayerCapsule;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();

        Physics.IgnoreCollision(PlayerCapsule.GetComponent<Collider>(), GetComponent<Collider>());
    }

    void Update()
    {
        
            
        
    }
}
