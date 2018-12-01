using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_open : MonoBehaviour {
    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public GameObject light4;
    public GameObject path2_door;
    // Use this for initialization
    void Start () {
       

    }
	
	// Update is called once per frame
	void Update () {
		if(light1.activeInHierarchy==true && light2.activeInHierarchy == true && light3.activeInHierarchy == true && light4.activeInHierarchy == true)
        {
            path2_door.SetActive(false);
        }
	}
}
