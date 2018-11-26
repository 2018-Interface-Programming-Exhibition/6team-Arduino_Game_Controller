using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomber : MonoBehaviour {
    public GameObject trap;
    public Transform respawn;
    //플레이어와 부딪히면 색변하고 플레이어는 제자리로 돌아옴
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        { 
            trap.GetComponent<MeshRenderer>().material.color = Color.red;
            other.transform.position = respawn.position;
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
