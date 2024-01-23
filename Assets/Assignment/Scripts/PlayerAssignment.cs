using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAssignment : MonoBehaviour
{
    [SerializeField] private float speed = 15f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float jumpForce = 50f;
    [SerializeField] private int isGrounded;
    [SerializeField] private int dir;
    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {
        move();
        jump();
        checkKey();
        teleport();
    }

    private void move()
    {
        //gets player input and make them move
        float direction = Input.GetAxis("Horizontal");
        float directionY = Input.GetAxis("Vertical");
        transform.Translate(speed * direction * Time.deltaTime, 0, 0);

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        // check if player is grounded and if so add to number of colided objects
        isGrounded++;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded--;
    }


    private void teleport()
    {
        //check is space was pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (dir == 2)
            {
                // if it was pressed and the last direction the player walked to was the right teleport to the right
                transform.position = new Vector3(transform.position.x + 5, transform.position.y, transform.position.z);
            }
            else if (dir == 1)
            {
                // if it was pressed and the last direction the player walked to was the left teleport to the left
                transform.position = new Vector3(transform.position.x - 5, transform.position.y, transform.position.z);
            }
        }
    }


    private void checkKey()
    {
        //check last direction

        if (Input.GetKeyDown(KeyCode.D))
        {
            //make direction 2 to show player walked to the right
            dir = 2;

        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            //make direction 1 to show player walked to the left
            dir = 1;
        }

    }
    private void jump()
    {
        if (isGrounded > 0)
        {
            //if player is coliding with someone let them jump
            if (Input.GetKey(KeyCode.W))
            {
                //add force to the rigid body to make them jump
                rb.AddForce(transform.up * jumpForce);

            }

        }
    }
}
