using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject door;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (door.activeSelf)
        {
            door.SetActive(false);

        }
        else if (!door.activeSelf)
        {
            door.SetActive(true);
        }
    }
}
