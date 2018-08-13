using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayEmitter : MonoBehaviour {

    Transform goTransform;
    LineRenderer lineRenderer;
    Ray ray;
    RaycastHit hit; //충돌체
    Vector3 inDirection;
    int nReflections = 100;//단계별로 변경 수가 작을수록 어렵다
    int nPoints;

	void Start () {
        goTransform = GetComponent<Transform>();
        Debug.Log(goTransform.position);
        lineRenderer = GetComponent<LineRenderer>();
	}
	

	void Update () {
        //nReflections = Mathf.Clamp(nReflections, 1, nReflections);
        ray = new Ray(goTransform.position, goTransform.forward);
        Debug.DrawRay(goTransform.position, goTransform.forward * 100, Color.yellow);//예비선
        nPoints = 2;
        //lineRenderer.SetVertexCount(nPoints);
        lineRenderer.SetPosition(0, goTransform.position);

        for (int i = 0; i <= nReflections; i++)
        {
            if (i == 0)
            {
                if (Physics.Raycast(ray.origin, ray.direction, out hit, 100))
                {
                    inDirection = Vector3.Reflect(ray.direction, hit.normal);
                    ray = new Ray(hit.point, inDirection);
                    Debug.DrawRay(hit.point, inDirection * 100, Color.yellow);//예비선
                    Debug.Log("Object name: " + hit.transform.name);
                    if (hit.transform.name == "Lock")
                    {
                        Debug.Log("Start animation");
                    }
                    if (nReflections == 1)
                    {
                        lineRenderer.SetVertexCount(++nPoints);//선 굵기 관련
                    }
                    lineRenderer.SetPosition(i + 1, hit.point);
                }
               else
                {
                    lineRenderer.SetPosition(i + 1, transform.forward * 5000);
                }
            }

            else
            {
                if (Physics.Raycast(ray.origin, ray.direction, out hit, 100))//충돌 했다면
                {
                    inDirection = Vector3.Reflect(inDirection, hit.normal);
                    ray = new Ray(hit.point, inDirection);
                    Debug.DrawRay(hit.point, inDirection * 100, Color.yellow);//예비선
                    Debug.Log("Object name: " + hit.transform.name);
                    if (hit.transform.name == "Lock")
                    {
                        Debug.Log("Start animation");
                    }
                    lineRenderer.SetVertexCount(++nPoints);
                    lineRenderer.SetPosition(i + 1, hit.point);
                }
               /* else
                {
                    lineRenderer.SetPosition(i + 1, transform.forward * 5000);
                }*/
            }
        }
	}
}
