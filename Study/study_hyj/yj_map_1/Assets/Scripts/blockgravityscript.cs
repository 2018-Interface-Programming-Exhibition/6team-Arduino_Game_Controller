using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//S 누르면 블럭이 하강하는 스크립트 입니다
// S -> 블럭 하강
//J, i, L-> 방향이동
//엔터키 -> 90도 회전
public class blockgravityscript : MonoBehaviour {

    public GameObject blockmaker;

	void Start () {
       blockmaker = GameObject.Find("blockblock");
        Debug.Log("I(blockgravityscript) find " + blockmaker.name);
	}

    private void OnTriggerStay(Collider other)
    {
            // S 누르면 블럭에 중력 작용
            if (Input.GetKeyDown(KeyCode.S))
            {
                if (other.tag == "blocktag")//블럭이라면 떨어트리기
                {
                    other.attachedRigidbody.isKinematic = false;
                    blockmaker.GetComponent<Blockcome>().enabled = true;
            }
            } 

        
            //90도 회전(키보드의 왼쪽 Shift키)
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
            Debug.Log("push S");
            if (other.tag == "blocktag")
                {
                    Debug.Log("Move MOve SS");
                    float yRot = other.transform.parent.rotation.y;
                    float xRot = other.transform.parent.rotation.x;
                    float zRot = other.transform.parent.rotation.z;
                    other.transform.parent.rotation = Quaternion.Euler(xRot, yRot + 90, zRot);
                }
            }

        //방향이동 J, I, L이용
        int speed = 100;
        //J는 왼쪽 <-
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (other.tag == "blocktag")//자리 이동(직접이동으로 해볼까 안되네...)
            {
                float fMove = Time.deltaTime * speed;
                other.transform.Translate(Vector3.left * fMove);
            }
        }
        //L은 오른쪽 ->
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (other.tag == "blocktag")
            {
                float fMove = Time.deltaTime * speed;
                other.transform.Translate(Vector3.right * fMove);
            }
        }
        //I는 위^
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (other.tag == "blocktag")
            {
                float fMove = Time.deltaTime * speed;
                other.transform.Translate(Vector3.forward * fMove);
            }
        }
        //K는 아래
        if (Input.GetKeyDown(KeyCode.J))
        {
            if (other.tag == "blocktag")
            {
                float fMove = Time.deltaTime * speed;
                other.transform.Translate(Vector3.back * fMove);
            }
        }

    }
}
