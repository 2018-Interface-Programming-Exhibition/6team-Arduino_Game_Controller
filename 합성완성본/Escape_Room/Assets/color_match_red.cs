using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color_match_red : MonoBehaviour {

    public GameObject trap;
    public GameObject light_red;  

    private void OnTriggerEnter(Collider other)
    {   
        if(other.GetComponent<MeshRenderer>().material.color == Color.red)
        {
            light_red.GetComponent<MeshRenderer>().material.color = Color.red;
            light_red.SetActive(true);
        }   
    }

    // Use this for initialization
    void Start () {
        trap.GetComponent<MeshRenderer>().material.color = Color.red;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
