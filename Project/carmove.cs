using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carmove : MonoBehaviour {
    int _time = (int)Time.time;

    Random randomGenerator;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(_time % 2000 == 0)
        {
            transform.position += transform.forward * 2 * Time.deltaTime;
            if(transform.position.x >= 6)
            {
                transform.Rotate(0,270,0);
            }
            else if (transform.position.x <= -2.75)
            {
                transform.Rotate(0, 90, 0);
            }
        }

    }
}
