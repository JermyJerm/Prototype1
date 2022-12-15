using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float speed = 150f;
    private float border = 10;

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (transform.position.z < border)
        {
            Destroy(gameObject);
        }
    }
}
