using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    bool jump = false;

    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.tag == "Block")
            || (collision.gameObject.name == "Start"))
        {
            jump = true;
        }
    }
    
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        float LR = 0.05f * Input.GetAxis("Horizontal");
        float UD = 0.05f * Input.GetAxis("Vertical");


        transform.position = new Vector3(
            transform.position.x - UD,
            transform.position.y,
            transform.position.z + LR);
        /*
        if(transform.position.y < -10.0f)
        {
            transform.position = new Vector3(4.5f, 5, 0.5f);    
        }
        */

        //jump
        if (Input.GetKeyDown(KeyCode.Space) && jump)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up*200);
            jump = false;
        }

	}
}
