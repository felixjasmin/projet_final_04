using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Variables limite des obstacles
    private float topBound = 400;
    private float lowerBound = -400;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            // Destroy me
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            // Destroy me
            Destroy(gameObject);
        }
    }
}