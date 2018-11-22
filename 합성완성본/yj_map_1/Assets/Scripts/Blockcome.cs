using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//tap키를 눌러 블럭을 생성 할 수 있는 스크립트 입니다. 플레이어가 플레이존에 없을땐 비활성화 되있습니다
public class Blockcome : MonoBehaviour
{

    GameObject[] blockk;
    public GameObject Block1;
    public GameObject Block2;
    public GameObject Block3;
    public GameObject Block4;
    public GameObject Block5;

    Vector3 whereme;
    GameObject blockcomeme;

    void Start()
    {
        // Block = new GameObject[5];
        blockk = new GameObject[5];
        blockk[0] = Block1;
        blockk[1] = Block2;
        blockk[2] = Block3;
        blockk[3] = Block4;
        blockk[4] = Block5;

        whereme = this.gameObject.transform.position;
        blockcomeme = this.gameObject;
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

    void Update()
    {
        //씨드 설정
        Random.seed = (int)System.DateTime.Now.Ticks;
        Debug.Log("time is " + Random.seed);

        //블럭 생성
        int i;
        i = Random.Range(0, 5);
        Instantiate(blockk[i], whereme, Quaternion.identity);
        Collider[] colls = Physics.OverlapSphere(blockk[i].transform.position, 50.0f);
        foreach (Collider coll in colls)
        {
            Rigidbody rbody = coll.GetComponent<Rigidbody>();
            if (rbody != null)
            {
                rbody.mass = 1.0f;
                rbody.AddExplosionForce(1000.0f, blockk[i].transform.position, 10.0f, 300.0f);
            }
        }
        //Instantiate(blockk[i], new Vector3(-15, 85, -120), Quaternion.identity);
        Debug.Log("you push TAP and object name is " + this.gameObject.name);
        blockcomeme.SetActive(false);
    }
}