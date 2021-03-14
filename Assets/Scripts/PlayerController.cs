using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // rate of forward/backward movement
   private float speed = 5.0f;
    // rate of turning's speed
   private float turnSpeed = 90.0f;

   private float horizontalInput;
   private float verticalInput;

    public Vector3 jump;
    public float jumpSpeed = 0.5f;
    public bool isGrounded;
    Rigidbody rb;
    public AudioSource JumpSound;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 0.75f, 0.0f);
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        Debug.Log(Time.deltaTime);
        // Code that allows forward and backward movement
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        // Code that allows turning
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rb.AddForce(jump * jumpSpeed, ForceMode.Impulse);
            isGrounded = false;
            JumpSound.Play();

        }
    }
}

