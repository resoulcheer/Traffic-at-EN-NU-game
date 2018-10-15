using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carmoveB : MonoBehaviour
{
    int _time = (int)Time.time;

    Random randomGenerator;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

            transform.position += transform.forward * 2 * Time.deltaTime;

            if (transform.position.z <= -14)
            {
                transform.Rotate(0, 0, 0);
            }
            if (transform.position.z >= 12)
            {
                transform.Rotate(0, 180, 0);
            }

    }
}
