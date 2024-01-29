using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyType2 : MonoBehaviour
{

    [SerializeField] private float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        spin();
    }


    private void spin()
    {
        //assing variable time * the speed
        float time =+ Time.deltaTime * speed;
       //use the variable as the gameObject's rotation file
        transform.Rotate(new Vector3(0, 0, time));
           


    }

    
}
