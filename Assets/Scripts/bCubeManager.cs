﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bCubeManager : MonoBehaviour
{
    private float cylindreSpeed = 450;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.down, Time.deltaTime * cylindreSpeed);
    }
}
