using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardfactor;
    [SerializeField] private float forwardspeed;
    public float sidefactor;
    [SerializeField] private float sidespeed;
    private int edge= 140;


    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (!ScoreManager.instance.isFinish)
        {
            forwardfactor = Joystick.instance.forward;
            sidefactor = Joystick.instance.side;

            if (forwardfactor > -edge && forwardfactor < edge)
            {
                transform.position += new Vector3(0, 0, forwardspeed * forwardfactor * Time.deltaTime);
                //rb.MovePosition(transform.position + new Vector3(0, 0, forwardspeed * forwardfactor * Time.deltaTime));
            }
            if (sidefactor > -edge && sidefactor < edge)
            {
                //rb.MovePosition(transform.position + new Vector3(sidespeed * sidefactor * Time.deltaTime, 0, 0));
                transform.position += new Vector3(sidespeed * sidefactor * Time.deltaTime, 0, 0);
            }
        }

        
    }
    
}
