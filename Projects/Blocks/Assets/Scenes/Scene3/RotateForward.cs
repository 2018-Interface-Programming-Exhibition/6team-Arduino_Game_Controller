using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateForward : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * 360f * Time.deltaTime * 0.1f);
    }
}
