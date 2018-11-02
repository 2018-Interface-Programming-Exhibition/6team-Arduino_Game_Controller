using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockcolor : MonoBehaviour
{
    public Material[] ccol;
    public int arraySIze;

    void Start () {
        arraySIze = 6;
        ccol = new Material[arraySIze];

        Renderer renderer = gameObject.GetComponent<Renderer>();

        int i;
        i = Random.Range(0, 6);
        renderer.material = ccol[i];
	}
	
	void Update () {
		
	}
}
