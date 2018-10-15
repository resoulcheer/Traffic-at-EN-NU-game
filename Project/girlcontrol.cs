using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girlcontrol : MonoBehaviour {
    public bool orcaractive = false;
    public float speed = 10;
    public float rotateSpeed = 70;
    // Use this for initialization
    void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * -speed * Time.deltaTime;
        }
        // Rotate
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotateSpeed * Time.deltaTime, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        }

        if (transform.position.x == 5.22)
        {
            if (transform.position.z == 11.5)
            {
                orcaractive = true;
            }
        }

    }
}
