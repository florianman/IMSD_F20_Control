﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trying : MonoBehaviour
{
    public Transform myTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            myTransform.position += Vector3.left;
        }
        
        if (Input.GetKeyDown(KeyCode.H))
        {
            myTransform.position += Vector3.right;
        }
    }   
}
