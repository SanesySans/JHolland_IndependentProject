using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // rate of forward/backward movement
   private float speed = 5.0f;
    // rate of turning's speed
   private float turnSpeed = 90.0f;

    // player movement inputs
   private float horizontalInput;
   private float verticalInput;

    // If player has powerup
    bool hasPowerUp = false;


    public Vector3 jump;
    public float jumpSpeed = 0.5f;
    // if player is grounded
    public bool isGrounded;
    Rigidbody rb;
    public AudioSource JumpSound;
    private GameObject[] objs;
    public ParticleSystem CoinGet;
    public GameObject PowerUpObject;
    // If player is invulnerable (Unused)
   // public bool Invuln = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 0.75f, 0.0f);
        objs = GameObject.FindGameObjectsWithTag("Coin");
        speed = 5.0f;
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

    // Code that activates sparkles upon collecting a coin
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            CoinGet.Play();
        }

        if (other.CompareTag("PowerUp"))
        {
            hasPowerUp = true;
            speed = 10.0f;
            turnSpeed = 180.0f;
            StartCoroutine(PowerUpCountdown());
            PowerUpObject.SetActive(true);
            //Invuln = true;
        }
    }

    IEnumerator PowerUpCountdown()
    {
        yield return new WaitForSeconds(8);
        hasPowerUp = false;
        PowerUpObject.SetActive(false);
        //Invuln = false;
        speed = 5.0f;
        turnSpeed = 90.0f;
    }
}

