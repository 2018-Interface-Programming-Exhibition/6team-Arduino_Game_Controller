using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_2 : MonoBehaviour
{

    float delta = -0.05f;
    int count = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float Zpos = transform.position.z + delta;
        count++;
        transform.position = new Vector3(
            transform.position.x,
            transform.position.y,
            Zpos);
        if (count == 25)
        {
            delta *= -1.0f;
            count *= -1;
        }

    }
}
