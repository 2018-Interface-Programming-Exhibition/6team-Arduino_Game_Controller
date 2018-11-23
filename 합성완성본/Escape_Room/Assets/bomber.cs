using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomber : MonoBehaviour {
    public GameObject trap;
    public Transform respawn;
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        { 
            trap.GetComponent<MeshRenderer>().material.color = Color.red;
            other.transform.position = respawn.position;
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
