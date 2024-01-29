using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionArea : MonoBehaviour
{
    public bool detected = false;
  

    //if player enters detection area ( coliders with it)
    private void OnTriggerStay2D(Collider2D collision)
    {
        detected = true;
        //set public boolean variable true
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //if not set it false 
        detected = false;
    }
}
