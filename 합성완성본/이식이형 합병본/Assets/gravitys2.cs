using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class usegravitys2 : MonoBehaviour {
    public GameObject block;
    private Rigidbody rb;
    float posY = 0;

	// Use this for initialization
	void Start () {
        posY = block.transform.position.y;		
	}
	
	// Update is called once per frame
	void Update () {
		if(block.transform.position.y < 102)
        {
            rb = GetComponent<Rigidbody>();
            rb.constraints = RigidbodyConstraints.FreezePositionY;
        }
        else if(block.transform.position.y > posY)
        {
            rb = GetComponent<Rigidbody>();
            rb.useGravity = true;
        }
	}
}
