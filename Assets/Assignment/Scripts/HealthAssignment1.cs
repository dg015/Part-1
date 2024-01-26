using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthAssignment1 : MonoBehaviour
{

    public float health = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        death();
    }



    private void death()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene("Assigment");
        }
    }
}
