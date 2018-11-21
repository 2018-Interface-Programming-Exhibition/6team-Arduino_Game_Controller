using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stagerestart : MonoBehaviour {
    public GameObject player;
     void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "ptr")
        {
            player.transform.position = new Vector3(-71, 104, 0);                    
        }
    }
}
