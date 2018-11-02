using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnHome : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Returnhome()
    {
        Application.LoadLevel("1.Start_Scene.");
    }
    public void OnClickExit()
    {
        Returnhome();
    }
}
