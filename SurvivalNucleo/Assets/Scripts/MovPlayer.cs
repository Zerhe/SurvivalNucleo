using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlayer : MonoBehaviour {
    private Rigidbody rgb;
    private bool forwad;
    private bool back;
    private bool right;
    private bool left;
    private bool run;
    private float vel;

    private void Awake()
    {
        rgb = GetComponent<Rigidbody>();
        vel = 100;
    }
    void Start ()
    {
        forwad = false;
        back = false;
        right = false;
        left = false;
        run = false;
	}
    void FixedUpdate()
    {
        if (forwad)
        {
            rgb.AddRelativeForce(Vector3.forward * Time.deltaTime * vel, ForceMode.Impulse);
        }

        if (back)
        {
            rgb.AddRelativeForce(Vector3.back * Time.deltaTime * vel, ForceMode.Impulse);
        }

        if (right)
        {
            rgb.AddRelativeForce(Vector3.right * Time.deltaTime * vel, ForceMode.Impulse);
        }

        if (left)
        {
            rgb.AddRelativeForce(Vector3.left * Time.deltaTime * vel, ForceMode.Impulse);
        }

        if (run)
        {
            rgb.AddRelativeForce(Vector3.forward * Time.deltaTime * (vel*2) , ForceMode.Impulse);
        }

    }
    void Update ()
    {
        if (Input.GetButton("Forwad"))
        {
            forwad = true;
        }
        else
            forwad = false;
        if (Input.GetButton("Back"))
        {
            back = true;
        }
        else
            back = false;
        if (Input.GetButton("Right"))
        {
            right = true;
        }
        else
            right = false;
        if (Input.GetButton("Left"))
        {
            left = true;
        }
        else
            left = false;
        if (Input.GetButton("Run"))
        {
            run = true;
        }
        else
            run = false;
    }
}
