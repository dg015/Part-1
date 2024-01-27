using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMover : MonoBehaviour
{
    [SerializeField] private float speed = 1f;

  

    // Update is called once per frame
    void Update()
    {
        //make transform travel fowards at all times based on speed
        transform.Translate(0, 1 * speed * Time.deltaTime, 0);
    }

    //check if object colided with another object
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // if so check if the objct has the player script
        if (collision.gameObject.TryGetComponent(out PlayerAssignment healthPlayer))
        {
            //if so remove 1 health point from player 
            healthPlayer.health = healthPlayer.health - 1;
            Debug.Log("hit");
        }
        //if colided destroy itself
        Destroy(this.gameObject);
    }
}
