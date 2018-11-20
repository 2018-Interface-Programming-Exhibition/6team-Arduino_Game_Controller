using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomber : MonoBehaviour {
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        { 
            //bomber.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
