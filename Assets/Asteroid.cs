using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Asteroid : MonoBehaviour
{
    public float speed = 3f;

    private void Start()
    {
        
        transform.rotation = Random.rotation;
    }

    private void Update()
    {
        
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}





