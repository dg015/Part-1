using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Rotator : MonoBehaviour
{
     [SerializeField] private float speed = 30.0f;
    [SerializeField] private float direction = 1f;
     
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

        rotation();
    }

    void rotation()
    {
        transform.Rotate(Vector3.forward, direction * speed  * Time.deltaTime);

    }
}
