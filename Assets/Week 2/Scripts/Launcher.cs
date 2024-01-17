using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject missile;
    [SerializeField] Transform spawn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(missile,spawn.position,spawn.rotation);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
