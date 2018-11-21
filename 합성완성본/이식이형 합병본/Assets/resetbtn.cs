using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetbtn : MonoBehaviour
{
    public GameObject player;
    public GameObject btn;
    public GameObject[] blockobj;
   
    public Quaternion[] qc;
    // Use this for initialization
    void Start()
    {
       blockobj = GameObject.FindGameObjectsWithTag("gravityblock");

    }
    void OnTriggerEnter(Collider col) //오브젝트끼리 충돌시
    {
        if (col.gameObject.tag == "resetbtn") // 충돌한 버튼의 태그가 resetbtn일시
        {
            GameObject[] objects = GameObject.FindGameObjectsWithTag("gravityblock"); // objects에 tag값이 gravirtblock인 오브젝트들이 들어감
            GameObject[] copy = GameObject.FindGameObjectsWithTag("gravityblock");
              Debug.Log("오류 안납니다1");

            Destroy(btn); // resetbtn을 파괴
            Debug.Log("오류 안납니다2");
            for (int i = 0; i < objects.Length; i++)
            {
                Debug.Log("오류 안납니다3");
                copy[i].transform.position = objects[i].transform.position;
                Debug.Log("오류 안납니다4" + copy[i].transform.position);
                copy[i].transform.rotation = objects[i].transform.rotation;
                Debug.Log("오류 안납니다5" + copy[i].transform.rotation);
                
                blockobj[i] = (GameObject)Instantiate(objects[i], copy[i].transform.position, copy[i].transform.rotation); // blockobj에 objects에 들어간 좌표의 위치에 클론생성
                Debug.Log("오브젝트생성" + objects[i] + copy[i].transform.position + copy[i].transform.rotation);
                Destroy(objects[i]);  // objects에 들어간 오브젝트들 파괴
                Debug.Log("오류 안납니다7");
               
            }
            Debug.Log("리셋은 성공적으로 끝");

            for (int s = 0; s < blockobj.Length; s++)
            {
               
                Debug.Log("오브젝트는 생성됐다");
                Debug.Log("오류 안납니다6");
            }

        }




    }

}

