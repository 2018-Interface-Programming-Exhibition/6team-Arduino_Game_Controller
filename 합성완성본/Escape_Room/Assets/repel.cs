using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repel : MonoBehaviour {

    public GameObject colun;
    public GameObject floor;
    private bool repelon=false;
    private bool repeluse=false;
    public GameObject User;
    public Transform department;

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Player") {
            repelon = true;
        }
       
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            repelon = false;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //플레이어가 기둥근처에있고 f키를 누를 때 위치변경
		if(repeluse==false && repelon==true && Input.GetKeyDown("f"))
        {
            repeluse = true;
            //유저 위치 변경 User.transform.position = new Vector3()
        }
        //플레이어가 기둥을 타고 내려갈때 f키를 누르면 위치변경
        if(repeluse == true&&Input.GetMouseButton(0))
        {
            User.transform.position = department.position;
        }
	}
}
