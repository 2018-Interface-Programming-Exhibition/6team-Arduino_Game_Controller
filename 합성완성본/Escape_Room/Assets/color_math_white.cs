using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color_math_white : MonoBehaviour {


    public GameObject trap;
    public GameObject light_white;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<MeshRenderer>().material.color == Color.white)
        {
            light_white.GetComponent<MeshRenderer>().material.color = Color.white;
            light_white.SetActive(true);
        }
    }

    // Use this for initialization
    void Start () {
        trap.GetComponent<MeshRenderer>().material.color = Color.white;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
