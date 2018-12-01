using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color_red : MonoBehaviour {

    public GameObject red_object;

	// Use this for initialization
	void Start () {
        red_object.GetComponent<MeshRenderer>().material.color = Color.red;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
