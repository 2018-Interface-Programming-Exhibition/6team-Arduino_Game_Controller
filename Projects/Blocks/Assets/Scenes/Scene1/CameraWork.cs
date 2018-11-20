using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWork : MonoBehaviour {

    

    GameObject ball;
	// Use this for initialization
	void Start () {
        ball = GameObject.Find("Ball");

        transform.Rotate(45, -90, 0);
    }

	// Update is called once per frame
	void Update () {
    
        
        //FPP
//      transform.position = ball.transform.position;
        

        
        //TPP
        transform.position = new Vector3(
            ball.transform.position.x +5,
            ball.transform.position.y +5,
            ball.transform.position.z);

        

       
    }
   


    //Lerp method를 이용한 부드러운 카메라
    /*
    public void FixedUpdate()
    {
        Vector3 TargetPos = new Vector3(
        ball.transform.position.x + 5,
        ball.transform.position.y + 5,
        ball.transform.position.z);
        
        

        transform.position = Vector3.Lerp(
            transform.position, TargetPos, Time.deltaTime * 2f);
    }

    */
}
