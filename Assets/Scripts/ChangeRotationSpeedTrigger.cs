﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRotationSpeedTrigger : MonoBehaviour
{
    public float speedIncrease;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Button")
        {
            RotateSky.RotateSpeed = RotateSky.RotateSpeed + speedIncrease;
        }
    }
}