using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//tap키를 눌러 블럭을 생성 할 수 있는 스크립트 입니다. 플레이어가 플레이존에 없을땐 비활성화 되있습니다
public class Blockcome : MonoBehaviour {

    GameObject[] blockk;
    public GameObject Block1;
    public GameObject Block2;
    public GameObject Block3;
    public GameObject Block4;
    public GameObject Block5;


    void Start () {
        // Block = new GameObject[5];
        blockk = new GameObject[5];
        blockk[0] = Block1;
        blockk[1] = Block2;
        blockk[2] = Block3;
        blockk[3] = Block4;
        blockk[4] = Block5;

        /*StartCoroutine("Blockking");*/
    }

    /*IEnumerator Blockking()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            int i;
            i = Random.Range(0, 4);
            Instantiate(blockk[i], new Vector3(-15, 85, -120), Quaternion.identity);
        }
    }*/


    void Update () {
        //tap키 누르면 블럭 생성
        if (Input.GetKeyDown(KeyCode.Tab))
            {
                int i;
                i = Random.Range(0, 5);
                Instantiate(blockk[i], new Vector3(-15, 85, -120), Quaternion.identity);
                Debug.Log("you push TAP and object name is " + this.gameObject.name);
                this.gameObject.GetComponent<Blockcome>().enabled = false;
            }
    }
}
