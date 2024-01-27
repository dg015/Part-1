using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathLaser : MonoBehaviour
{
    // check if player oolides with it 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if so get player component and health variable
        if (collision.gameObject.TryGetComponent(out PlayerAssignment healthPlayer))
        {
            //set player healht to 0
            healthPlayer.health = 0;
            Debug.Log("hit");
        }
    }

}
