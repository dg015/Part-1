using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Traveler : MonoBehaviour
{

    [SerializeField] private float speed = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(1 * speed * Time.deltaTime,0,0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }


}
