using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 startingPos = new Vector3(-96, -107.5f, -309);
    private float travelSpeed = 5f;
    public bool partF;
    private Vector3 tpOne = new Vector3(-5, 0.5f, 48);
    public bool partS;
    private Vector3 tpTwo = new Vector3(-3, 0.5f, -14);

    // Start is called before the first frame update
    void Start()
    {
        transform.position = startingPos;
        partF = true;
        partS = false;
        travelSpeed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (partF == true)
        {
            partS = false;
            if (transform.position.z > -349)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * travelSpeed);
            }
            else
            {
                transform.Translate(Vector3.forward * Time.deltaTime * travelSpeed * 0);
                travelSpeed = 15;
                transform.Translate(Vector3.right * Time.deltaTime * travelSpeed);
            }
        }
        else if (partS == true)
        {
            transform.Translate(Vector3.right * Time.deltaTime * travelSpeed * 0);
            travelSpeed = 0.7f;
            if (transform.position.z > -9)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * travelSpeed);
            }
            else
            {
                transform.Translate(Vector3.forward * Time.deltaTime * travelSpeed * 0);
                transform.position = tpTwo;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("SphereTpOne"))
        {
            partF = false;
            partS = true;
            transform.position = tpOne;
        }
    }
}
