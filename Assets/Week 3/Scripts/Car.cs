using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    float acceleration;
    float sterring;
    [SerializeField] float fowardSpeed = 500f;
    [SerializeField] float steeringSpeed = 100f;
    [SerializeField] float maxSpeed = 50f;
    Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        acceleration = Input.GetAxis("Vertical");
        sterring = Input.GetAxis("Horizontal");


    }
    private void FixedUpdate()
    {
      rigidbody.AddTorque(-sterring * steeringSpeed * Time.deltaTime);  
      Vector2 force = transform.up * acceleration * fowardSpeed * Time.deltaTime;
        rigidbody.AddForce(force);
        if (rigidbody.velocity.magnitude < maxSpeed)
        {
            rigidbody.AddForce(force);

        }
    }
}
