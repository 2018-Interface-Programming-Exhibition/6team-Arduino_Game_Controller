using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color_blue : MonoBehaviour {
    public GameObject blue_object;
	// Use this for initialization
	void Start () {
        blue_object.GetComponent<MeshRenderer>().material.color = Color.blue;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
