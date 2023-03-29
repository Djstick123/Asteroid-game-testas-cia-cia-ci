using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;

    private void Start()
    {
        
        Destroy(gameObject, 3f);
    }

    private void Update()
    {
        
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Asteroid")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}






