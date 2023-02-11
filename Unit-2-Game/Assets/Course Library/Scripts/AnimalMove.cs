﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMove : MonoBehaviour
{
    float speed = 15f;
    int bottomBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < -10)
        {
            Destroy(gameObject);
        }

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
