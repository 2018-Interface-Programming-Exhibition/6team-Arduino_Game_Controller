using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color_black : MonoBehaviour {

    public GameObject black_object;

	// Use this for initialization
	void Start () {
        black_object.GetComponent<MeshRenderer>().material.color = Color.black;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
