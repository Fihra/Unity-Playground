using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float speedForward = 1000f;
    float currentSpeed = 1050f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.AddForce(0, 0, currentSpeed * Time.deltaTime);
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        rb.AddForce(horizontal * speedForward * Time.deltaTime, 0, 0, ForceMode.VelocityChange); 
    }
}
