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
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        searchMode();

    }

    private void searchMode()
    {
        if (detection.GetComponent<DetectionArea>().detected == true)
        {
            timer();
            if (ready)
            {
                AttackMode();
            }
        }



    }

    private void timer()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else if (time < 0)
        {
            time = 1f;
            ready = true;
        }

    }

    private void AttackMode()
    {
        ready = false;

        Debug.Log("found enemy");
        //barrel.LookAt(target.position);


        Vector2 dir = target.position - transform.position;
        float ang = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        // Get the angle in radiants of the direction the enemy to the player 
        //than gets the exact quadrom and later converts it into degrees
        ang = ang - 90;
        transform.rotation = Quaternion.Euler(0, 0, ang);
        Instantiate(bullet, barrel.position, barrel.rotation);


        //transform.Rotate(dir);
        //transform.rotation = Quaternion.LookRotation(dir);


    }
}
