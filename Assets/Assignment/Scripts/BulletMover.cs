using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMover : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float speed = 1f;
    //[SerializeField] HealthAssignment1 healthPlayer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(0, 1 * speed * Time.deltaTime, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out HealthAssignment1 healthPlayer))
        {
            healthPlayer.health = healthPlayer.health - 1;
            Debug.Log("hit");
        }
        Destroy(this.gameObject);
    }
}
