using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour {
   private CharacterController controller;
    private Vector3 direction;

    // Use this for initialization
    public float moveSpeed = .3f;
    //public float jumpPower = 5f;
    private Rigidbody rigidBody;
    private int desiredLane = 1;
    //public float laneDistance = 2.5f;
    /*private bool onGrnd = true;
    private const int max_jump = 2;
    private int count = 0;*/

    private void Start()
    {
        //controller = GetComponent<CharacterController>();
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    { 
        Vector3 forwardMovement = Vector3.forward.normalized;
        Vector3 rightMovement = Vector3.right.normalized;
        Vector3 leftMovement = Vector3.left.normalized;
        rigidBody.AddForce(forwardMovement * moveSpeed);
        rigidBody.AddForce((rightMovement + leftMovement) * moveSpeed);
        //direction.z = moveSpeed;
        /*if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            desiredLane++;
            if (desiredLane == 3)
            {
                desiredLane = 2;
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            desiredLane--;
            if (desiredLane == -1)
            {
                desiredLane = 0;
            }
        }
        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;
        if (desiredLane == 0)
        {
            targetPosition += Vector3.left * laneDistance;
        }
        else if (desiredLane == 2)
        {
            targetPosition += Vector3.right * laneDistance;
        }
        transform.position = Vector3.Lerp(transform.position, targetPosition, 100f * Time.deltaTime);
        if (Input.GetButtonDown("space") && (onGrnd || max_jump > count))
        {
            rigidBody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            onGrnd = false;
            count++;
        }*/
    }
    /*private void onCollisionEnter(Collision collision)
    {
        onGrnd = true;
        count = 0;
    }

    private void FixedUpdate()
    {
        controller.Move(direction * Time.fixedDeltaTime);
    }*/

}
