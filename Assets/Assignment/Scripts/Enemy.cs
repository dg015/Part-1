using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform barrel;
    [SerializeField] private Transform target;
    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject detection;
    [SerializeField] private float time;
    [SerializeField] private bool ready;
    // Start is called before the first frame update
    void Start()
    {
        //find plaeyrs transform location and assignt it to tranform variable
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        searchMode();

    }

    private void searchMode()
    {
        // if player is inside the detection range the other script will return a true value
        if (detection.GetComponent<DetectionArea>().detected == true)
        {
            //check if value is true and if true start timer
            timer();
        }



    }

    private void timer()
    {
        //while time is more than 0
        if (time > 0)
        {
            //deduct one from time variable every second 
            time -= Time.deltaTime;
        }
        //if timer reaches 0
        else if (time <= 0)
        {
            // reset timer
            time = 1f;
            AttackMode();
        }

    }

    private void AttackMode()
    {
        Vector2 dir = target.position - transform.position;
        float ang = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        // Get the angle in radiants of the direction the enemy to the player 
        //than gets the exact quadrom and later converts it into degrees
        ang = ang - 90;
        transform.rotation = Quaternion.Euler(0, 0, ang);
        Instantiate(bullet, barrel.position, barrel.rotation);

    }
}
