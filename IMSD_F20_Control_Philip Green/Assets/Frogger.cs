﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frogger : MonoBehaviour
{
    public Transform myTransform;
    private float speed = 9.5f;
    // Start is called before the first frame update
    void Start()
    {
        myTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q)) //Hold key to be true.
        {
            myTransform.position += new Vector3(0, Time.deltaTime * speed, 0);
        }



        if (Input.GetKeyUp(KeyCode.Q))
        {
            myTransform.position += Vector3.up;
        }
    
        if (Input.GetKey(KeyCode.P))
        {
            myTransform.position += new Vector3(0, -Time.deltaTime * speed, 0);
        }

        if (Input.GetKeyUp(KeyCode.P))
        {
            myTransform.position += Vector3.down;
        }
    }   
}