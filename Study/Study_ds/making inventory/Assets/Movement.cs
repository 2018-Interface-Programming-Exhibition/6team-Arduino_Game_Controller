using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    float speed = 5.0f;//움직이는 속도.
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))//앞으로 움직이기
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))//옆으로 움직이기
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))//왼쪽으로 움직이기
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))//오른쪽으로 움직이기
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))//왼쪽회전
        {
            transform.Rotate(Vector3.down * 5.0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))//오른쪽회전
        {
            transform.Rotate(Vector3.up * 5.0f);
        }
        if (Input.GetKeyDown(KeyCode.R))//에러시 현재 씬 재시작
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
