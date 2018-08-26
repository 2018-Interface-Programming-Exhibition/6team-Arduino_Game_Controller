using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_camera : MonoBehaviour {
    public Transform p;// 어떤 물체를 따라 움직일 것 인가를 정한다.
    public float smooth = 5f; //부드럽게 따라가기 위해서 지정.
    private Transform tr;// 카메라가 무엇을 바라볼 지 지정하기 위함이다.
    // Use this for initialization
    void LateUpdate()//가장 마지막에 업데이트 된다. 맨 마지막에 구성이 다 되고 플레이어를 따라 움직이게 하기 위함.
    {
        float cangle = Mathf.LerpAngle(tr.eulerAngles.y, p.eulerAngles.y, smooth * Time.deltaTime);
        Quaternion rot = Quaternion.Euler(0, cangle, 0);
        tr.position = p.position - (rot * Vector3.forward * 10) + (Vector3.up * 5);
        tr.LookAt(p);
    }

    void Start () {
        tr = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
