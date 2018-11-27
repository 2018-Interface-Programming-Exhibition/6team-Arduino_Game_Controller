using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color_match : MonoBehaviour {

    //public gameobject light // 켜지게 하고싶어요 

    private void OnTriggerEnter(Collider other)
    {   
        if(other.GetComponent<MeshRenderer>().material.color == Color.red)
        {   
            //gameobject light 가 켜져요 
        }   
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
