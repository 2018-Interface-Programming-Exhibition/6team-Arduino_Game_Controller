using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itembehave : MonoBehaviour {
    private bool itemget;//아이템 상호작용 변수
    public bool holding;//아이템 잡고있나 안잡고있나
    public GameObject Item;//아이탬 오브젝트 변수
    public Transform player;//플레이어 지정변수
	// Use this for initialization
	void Start () {
        itemget = false;
        holding = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (itemget &&!holding&&Input.GetKeyDown("f"))
        {
            Item.transform.parent = (player);
            holding = true;

        }
        if (holding)
        {
            Item.transform.localPosition = new Vector3(0, 0.1f, 0.7f);
            if (Input.GetMouseButton(0))
            {
                Item.transform.parent = null;
                holding = false;
            }
        }
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item"&&!holding)
        {
            itemget = true;
            Item = other.gameObject;
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Item")
        {
            itemget = false;
        }
    }
}
