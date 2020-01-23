using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;

    public GameObject wordpanel;

    public float sideForce = 500f;

    private void Start()
    {
        Material M = rb.gameObject.GetComponent<Material>();

        Destroy(M);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (!wordpanel.activeSelf)
        {
            //move around
            if (Input.GetKey("right"))
            {
                rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if (Input.GetKey("left"))
            {
                rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if (Input.GetKey("up"))
            {
                rb.AddForce(0, 0, sideForce * Time.deltaTime, ForceMode.VelocityChange);
            }

            if (Input.GetKey("down"))
            {
                rb.AddForce(0, 0, -sideForce * Time.deltaTime, ForceMode.VelocityChange);
            }
        }
    }
}
