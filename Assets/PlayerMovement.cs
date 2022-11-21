using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Time.deltaTime renvoie le temps en seconde écoulé depuis la derniere frame
    // velocity : combine la notion de vitesse et celle de direction

    Rigidbody rigidBody;
    [SerializeField] float movementSpeed = 5f;
    [SerializeField] float jumpForce = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Get the value of the Horizontal input axis.
        float horizontalInput = Input.GetAxis("Horizontal");
        //Get the value of the Vertical input axis.
        float verticalInput = Input.GetAxis("Vertical");

        rigidBody.velocity = new Vector3(horizontalInput * movementSpeed, rigidBody.velocity.y, verticalInput * movementSpeed);

        if (Input.GetButtonDown("Jump"))
        {
            rigidBody.velocity = new Vector3(rigidBody.velocity.x, jumpForce, rigidBody.velocity.z);
        }

    }
}
