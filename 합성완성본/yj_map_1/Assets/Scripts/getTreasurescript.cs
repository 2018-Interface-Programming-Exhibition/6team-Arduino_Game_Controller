using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getTreasurescript : MonoBehaviour {
    GameObject player;
    GameObject playerHand;
    GameObject Ball;
    bool isPlayerEnter;

	void Start () {
        player = GameObject.Find("FPSController");
        playerHand = GameObject.Find("treasureInMyHand");
        Ball = GameObject.Find("treasure_tetris");
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
            isPlayerEnter = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
            isPlayerEnter = false;
    }

    void Update () {
        //G누르면 보물을 얻는다
        if (Input.GetKeyDown(KeyCode.G) && isPlayerEnter)
        {
            Ball.transform.SetParent(playerHand.transform);
            Ball.transform.localPosition = Vector3.zero;
            Ball.transform.rotation = new Quaternion(0, 0, 0, 0);

            isPlayerEnter = false;
        }
        if (this.gameObject.transform.parent == player)
        {
            Ball.transform.localPosition = Vector3.zero;
            Ball.transform.rotation = new Quaternion(0, 0, 0, 0);
        }
	}
}
