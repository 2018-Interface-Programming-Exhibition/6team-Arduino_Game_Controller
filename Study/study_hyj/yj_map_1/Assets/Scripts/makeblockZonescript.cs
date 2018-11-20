using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeblockZonescript : MonoBehaviour {

    public GameObject[] makeblocks;
    public GameObject makeblock1;
    public GameObject makeblock2;
    public GameObject makeblock3;
    public GameObject makeblock4;
    public GameObject makeblock5;
    public GameObject makeblock6;
    public GameObject makeblock7;
    public GameObject makeblock8;
    public GameObject makeblock9;

    public Vector3[] makewhere;

    void Start () {
        makeblocks = new GameObject[9];
        makeblocks[0] = makeblock1;
        makeblocks[1] = makeblock2;
        makeblocks[2] = makeblock3;
        makeblocks[3] = makeblock4;
        makeblocks[4] = makeblock5;
        makeblocks[5] = makeblock6;
        makeblocks[6] = makeblock7;
        makeblocks[7] = makeblock8;
        makeblocks[8] = makeblock9;

        makewhere = new Vector3[9];
        for (int i = 0; i < 9; i++)
        {
            makewhere[i] = makeblocks[i].transform.position;
        }
        StartCoroutine(StartCo());
    }

    IEnumerator StartCo()
    {
        while (true) {
            yield return new WaitForSeconds(0.3f);//5초
            //Random.seed = (int)System.DateTime.Now.Ticks + 999;
            //Debug.Log("time is " + Random.seed);
            int i;
            i = Random.Range(0, 8);
            makeblocks[i].SetActive(true);
        }
    }

    /*	void Update () {
            //씨드 설정
            Random.seed = (int)System.DateTime.Now.Ticks + 999;
            Debug.Log("time is " + Random.seed);

            int i;
            i = Random.Range(0, 8);
            makeblocks[i].SetActive(true);
            this.gameObject.SetActive(false);
        }*/
}
