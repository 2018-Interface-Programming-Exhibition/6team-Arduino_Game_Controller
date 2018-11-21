using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class usegravity : MonoBehaviour {

   
    public GameObject block;
    private Rigidbody rb;
    float posY = 0;

    void Start()
    {
        posY = block.transform.position.y;
    }
   
    void Update()
    {
        if (block.transform.position.y < posY)
        {
            rb = GetComponent<Rigidbody>();
            rb.useGravity = true;
           
        }
       else if(block.transform.position.y > posY)
        {
            rb = GetComponent<Rigidbody>();
            rb.useGravity = true;
        }


    }
}
