using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour {

    public GameObject Button;
    public GameObject path1;
    public GameObject path2;
    private bool buttonuse;

    private void OnTriggerEnter(Collider other)
    {
        

        if (other.transform.tag == "Player")
        {
            buttonuse = true;

        }
    }

    private void OnTriggerExit(Collider other)
    {


        if (other.transform.tag == "Player")
        {
            buttonuse = false;

        }
    }



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //버튼 누르면 색 변하고 통로 열림
        if (buttonuse == true && Input.GetKeyDown("f"))
        {
            Button.GetComponent<MeshRenderer>().material.color = Color.red;
            path1.SetActive(false);
            path2.SetActive(false);
        }
	}
}
