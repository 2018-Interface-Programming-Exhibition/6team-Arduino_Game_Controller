using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {
    LineRenderer Ir;
	// Use this for initialization
	void Start () {
        Ir = GetComponent<LineRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        Ir.SetPosition(0, transform.position);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider)
            {
                Ir.SetPosition(1, hit.point);
            }
        }
        else Ir.SetPosition(1, transform.forward * 5000);
    }
}
