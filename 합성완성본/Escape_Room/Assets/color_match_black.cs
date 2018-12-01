using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color_match_black : MonoBehaviour {

    public GameObject trap;
    public GameObject light_black;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<MeshRenderer>().material.color == Color.black)
        {
            light_black.GetComponent<MeshRenderer>().material.color = Color.black;
            light_black.SetActive(true);
        }
    }

    // Use this for initialization
    void Start () {
        trap.GetComponent<MeshRenderer>().material.color = Color.black;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
