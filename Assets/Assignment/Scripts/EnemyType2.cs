using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyType2 : MonoBehaviour
{
    [SerializeField] private Transform barrel;
    [SerializeField] private Transform target;
    [SerializeField] private GameObject bullet;
    [SerializeField] private float time;
    [SerializeField] private bool ready;
    [SerializeField] private GameObject detection;
    [SerializeField] private float rot;
    [SerializeField] private float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        spin();
    }


    


    private void spin()
    {

        float time =+ Time.deltaTime * speed;
       
        transform.Rotate(new Vector3(0, 0, time));
            //rotation = Quaternion.Euler(0, 0, rot + time);


    }

    
}
