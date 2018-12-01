using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color_match_blue : MonoBehaviour {

    public GameObject trap;
    public GameObject light_blue;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<MeshRenderer>().material.color == Color.blue)
        {
            light_blue.GetComponent<MeshRenderer>().material.color = Color.blue;
            light_blue.SetActive(true);
        }
    }

    // Use this for initialization
    void Start () {
        trap.GetComponent<MeshRenderer>().material.color = Color.blue;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
