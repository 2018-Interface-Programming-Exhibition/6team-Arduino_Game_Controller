using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stratbutton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Startgame()
    {
        Application.LoadLevel("2.Ingame_Scene");
    }
    public void OnClickExit()
    {
        Startgame();
    }
}
