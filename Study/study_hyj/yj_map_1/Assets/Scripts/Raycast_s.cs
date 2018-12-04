using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast_s : MonoBehaviour {
    public int catch_block;

    void OnCreate() { }
    void OnUpdate() { }

    void OnDrawGizmos()
    {

        float maxDistance = 500;
        RaycastHit hit;
        // Physics.Raycast (레이저를 발사할 위치, 발사 방향, 충돌 결과, 최대 거리)
        bool isHit = Physics.Raycast(transform.position, transform.forward, out hit, maxDistance);

        Gizmos.color = Color.red;
        if (isHit)
        {
            Gizmos.DrawRay(transform.position, transform.forward * hit.distance);
        }
        else
        {
            Gizmos.DrawRay(transform.position, transform.forward * maxDistance);
        }
    }

    void Start () {	}
	
	void Update () {
        float maxDistance = 500;
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, maxDistance))
        {
            if (hit.collider.tag == "blocktag")
                catch_block = 1;
            else
                catch_block = 0;
        }
        
    }
}
