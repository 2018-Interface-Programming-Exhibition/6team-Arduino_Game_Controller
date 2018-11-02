using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IGmessage : MonoBehaviour {
    public GameObject Itemgettingmessage;//아이템줍기 기능 나타내는 메세지
    public Itembehave itembehave;
    public bool a;
	// Use this for initialization
	void Start () {
        Itemgettingmessage.active = false;
	}
	
	// Update is called once per frame
	void Update () {
        a = itembehave.holding;
        if (a)
        {
            Itemgettingmessage.active = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Item"&&!a)
        {
            Itemgettingmessage.active = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Item")
        {
            Itemgettingmessage.active = false;
        }
    }
}
