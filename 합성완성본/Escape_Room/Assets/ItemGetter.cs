using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGetter : MonoBehaviour {
    private bool touch=false;
    public GameObject Player;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == Player)
        {
            touch = true;
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject == Player)
        {
            touch = false;
        }
    }
    void Start () {
        Player = GameObject.Find("Player"); 
	}
	
	
	void Update () {
		
	}
}
