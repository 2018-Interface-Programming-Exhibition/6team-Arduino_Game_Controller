using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class usetirgger : MonoBehaviour {
    public GameObject thisblock;
    private BoxCollider boxcol;
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "distroycube")
        {
            boxcol = GetComponent<BoxCollider>();
            boxcol.isTrigger = true;
        }
    }
}
