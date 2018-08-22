using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_camera : MonoBehaviour {
    public Transform p;
    public float ox = 0f;
    public float oy = 25f;
    public float oz=-35f;
    public float smooth = 5f;
    private Transform tr;
    // Use this for initialization
    void LateUpdate()
    {
        float cangle = Mathf.LerpAngle(tr.eulerAngles.y, p.eulerAngles.y, smooth * Time.deltaTime);
        Quaternion rot = Quaternion.Euler(0, cangle, 0);
        tr.position = p.position - (rot * Vector3.forward * 10) + (Vector3.up * 5);
        tr.LookAt(p);
    }

    void Start () {
        tr = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
