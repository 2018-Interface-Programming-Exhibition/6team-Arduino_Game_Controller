using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotoStart : MonoBehaviour {
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ball")
        {
            other.transform.position = new Vector3(4.5f, 5.0f, 0.5f);
        }
    }
    
    // Use this for initialization
    void Start () {

	}

	// Update is called once per frame
	void Update () {
		
	}
}
