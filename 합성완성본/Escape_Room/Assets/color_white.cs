using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color_white : MonoBehaviour {
    public GameObject white_object;
	// Use this for initialization
	void Start () {
        white_object.GetComponent<MeshRenderer>().material.color = Color.white;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
