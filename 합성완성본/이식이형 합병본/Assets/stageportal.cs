using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stageportal : MonoBehaviour
{

    public GameObject player;

    void OnTriggerEnter( Collider col)
    {
      if(col.gameObject.tag == "portal")
        {
            player.transform.position = new Vector3(3000, 11, 0);
        }
      else if(col.gameObject.tag == "portal2")
        {
            player.transform.position = new Vector3(0, 41, 0);
        }
        else if (col.gameObject.tag == "portal3")
        {
            player.transform.position = new Vector3(0, 100, 0);
        }
        else if (col.gameObject.tag == "portal4")
        {
            player.transform.position = new Vector3(-11, 125, 1);
        }
        else if (col.gameObject.tag == "clearportal")
        {
            player.transform.position = new Vector3(0, 1, 0);
        }

    }



}
