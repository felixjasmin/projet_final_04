﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eeCubeManager : MonoBehaviour
{
    private float cylindreSpeed = 300;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * cylindreSpeed);
    }
}