using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treasureZonescript : MonoBehaviour {
    GameObject treasureTetris;

    GameObject laserBall;
    GameObject floorblock;
    GameObject wallblock;

	void Start () {
        treasureTetris = GameObject.Find("treasure_tetris");

        laserBall = GameObject.Find("laserBall");
        floorblock = GameObject.Find("floorblock_1");
        wallblock = GameObject.Find("wallblock_2");

        laserBall.SetActive(false);
        floorblock.SetActive(false);
        wallblock.SetActive(false);
    }
	
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "treasuretag")
        {
                laserBall.SetActive(true);
                floorblock.SetActive(true);
                wallblock.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "treasuretag")
        {
                laserBall.SetActive(false);
                floorblock.SetActive(false);
                wallblock.SetActive(false);
        }
    }
}
