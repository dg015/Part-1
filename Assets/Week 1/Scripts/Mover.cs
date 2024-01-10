using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Mover : MonoBehaviour
{
   [SerializeField] GameObject missilePrefab;
    [SerializeField] private float speed = 3f;
    [SerializeField] private Transform barrel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
       transform.Translate(speed* direction * Time.deltaTime,0,0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(missilePrefab,barrel.position, barrel.rotation);
        }
    }
}
