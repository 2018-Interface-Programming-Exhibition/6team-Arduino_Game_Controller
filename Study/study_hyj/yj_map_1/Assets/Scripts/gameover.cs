using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour {

    GameObject[] children;
    GameObject blockcomer;
    public GameObject child1;
    public GameObject child2;
    public GameObject child3;
    public GameObject child4;
    public GameObject child5;
    public GameObject child6;
    public GameObject child7;
    public GameObject child8;
    public GameObject child9;
    public GameObject child10;
    public GameObject child11;
    public GameObject child12;
    public GameObject child13;
    public GameObject child14;
    public GameObject child15;

    void Start() {
        children = new GameObject[15];

        children[0] = child1;
        children[1] = child2;
        children[2] = child3;
        children[3] = child4;
        children[4] = child5;
        children[5] = child6;
        children[6] = child7;
        children[7] = child8;
        children[8] = child9;
        children[9] = child10;
        children[10] = child11;
        children[11] = child12;
        children[12] = child13;
        children[13] = child14;
        children[14] = child15;
}
	
	// Update is called once per frame
	void Update () {
        int over = 1;
        for (int i = 0; i < 15; i++)
        {
            int a = children[i].GetComponent<Raycast_s>().catch_block;
            if (a == 0)
            {
                over = 0;
            }
        }	


         if (over == 1)
        {
            Debug.Log("GAME OVER");
            blockcomer = GameObject.Find("makeblockZone");
            blockcomer.SetActive(false);
        }
	}
}
