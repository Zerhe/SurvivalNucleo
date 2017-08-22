using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotPlayer : MonoBehaviour {
    private float velRot;
    private Rigidbody rgb;

	void Start () {
        velRot = 80;
	}
    private void Awake()
    {
        rgb = GetComponent<Rigidbody>();
    }
    void Update () {
		if (Input.GetAxis("Mouse X") > 0)
        {
            rgb.AddRelativeTorque(Vector3.up * Time.deltaTime * velRot);
        }
        else if(Input.GetAxis("Mouse X") < 0)
        {
            rgb.AddRelativeTorque(Vector3.down * Time.deltaTime * velRot);
        }
        if (Input.GetAxis("Mouse Y") > 0)
        {
            rgb.AddRelativeTorque(Vector3.left * Time.deltaTime * velRot);
        }
        else if (Input.GetAxis("Mouse Y") < 0)
        {
            rgb.AddRelativeTorque(Vector3.right * Time.deltaTime * velRot);
        }
    }
}
