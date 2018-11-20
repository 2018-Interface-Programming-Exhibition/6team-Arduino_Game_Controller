using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class test2 : MonoBehaviour {

    public int Speed;
    public static bool KeyState;

    // Use this for initialization
    void Start () {
        KeyState = true;
	}
	
	// Update is called once per frame
	void Update () {
        if(KeyState == true)
        {

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(Vector3.left * Speed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(Vector3.right * Speed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(Vector3.forward * Speed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector3.back * Speed * Time.deltaTime);
            }
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            test2.KeyState = !test2.KeyState;
        }
    }
}
