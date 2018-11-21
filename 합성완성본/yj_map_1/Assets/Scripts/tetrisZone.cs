using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//테트리스 존에 플레이어가 가면 blockcomes.cs/blockgravityscropt.cs 스크립트가 활성화되는 스크립트 입니다
//blockcomes.cs/blockgravityscropt.cs : 블럭 생성/블럭 회전 및 이동
public class tetrisZone : MonoBehaviour {

    public GameObject blockkblockk;
    public GameObject blockkgravity;
    public GameObject player;

	void Start () {
        blockkblockk = GameObject.Find("blockblock");
        blockkgravity = GameObject.Find("blockgravity_Zone");
        player = GameObject.Find("FPSController");

        blockkblockk.gameObject.SetActive(false);
        blockkgravity.gameObject.SetActive(false);
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Who you R?"+ other.name);
        if (other.gameObject == player)
        {
            Debug.Log("He is come !!");
            blockkblockk.gameObject.SetActive(true);
            blockkgravity.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        blockkblockk.gameObject.SetActive(false);
    }
}
