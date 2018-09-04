using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float yInput = Input.GetAxis("Horizontal");
        Debug.Log(yInput);
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x,
                                                transform.localEulerAngles.y+yInput,
                                                transform.localEulerAngles.z);

	}
}
