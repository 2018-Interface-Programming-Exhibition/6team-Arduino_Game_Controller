using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserscript : MonoBehaviour {

    Transform goTransform;//위치 정보 사용을 위해 임포트
    LineRenderer lineRenderer;//라인렌더러 기능 사용을 위해 임포트
    Ray ray;
    RaycastHit hit;// 충돌체
    Vector3 inDirection;//레이의 진행 방향
    int nReflects = 100;//반사 횟수
    int nPoints;//레이의 지점

	void Start () {
        goTransform = GetComponent<Transform>();//위치 불러오기
        Debug.Log(goTransform.position);//개발의 편의를 위해 위치 드러내기
        lineRenderer = GetComponent<LineRenderer>();//라인렌더러 이용을 위해 초기화 하기
	}
	
	void Update () {
        ray = new Ray(goTransform.position, goTransform.forward);//레이 생성(시작점, 끝점)
        Debug.DrawRay(goTransform.position, goTransform.forward * 100, Color.white);//개발의 편의를 위해 레이의 진행 나타내기
        nPoints = 2;
        lineRenderer.positionCount = nPoints;//lineRenderer의 point를 센다 = 2번째
        lineRenderer.SetPosition(0, goTransform.position);//레이 위치 결정 0에서부터 현재 위치까지(?)

        for (int i = 0; i <= nReflects; i++)
        {
            if (i == 0)
            {
                if (Physics.Raycast(ray.origin, ray.direction, out hit, 500))//레이 길이100, hit는 충돌한 오브젝트
                {//즉, 충돌했다면
                    inDirection = Vector3.Reflect(ray.direction, hit.normal);
                    ray = new Ray(hit.point, inDirection);//레이생성(충돌지점, 방향)

                    //레이 위치와 충돌체의 이름 출력
                    Debug.DrawRay(hit.point, inDirection * 100, Color.white);
                    Debug.Log("Object name:" + hit.transform.name);
                    //if(nReflections == 1)코드 생략
                    lineRenderer.SetPosition(i + 1, hit.point);//라인렌더러를 통해 플레이어에게 드러내기
                }
                else
                {//충돌하지 않았다면
                    lineRenderer.SetPosition(i + 1, transform.forward * 500);
                }
            }
            else
            {//첫 번쨰 충돌이 아니라면
                if (Physics.Raycast(ray.origin, ray.direction, out hit, 500))
                {
                    if (hit.transform.name == "Sphere") ;
                    else
                    {

                        inDirection = Vector3.Reflect(inDirection, hit.normal);//방향 지정
                        ray = new Ray(hit.point, inDirection);

                        //레이 위치와 충돌체의 이름 출력
                        Debug.DrawRay(hit.point, inDirection * 100, Color.white);
                        Debug.Log("Object name:" + hit.transform.name);

                        lineRenderer.positionCount = ++nPoints; //지점의 갯수 늘리고
                        lineRenderer.SetPosition(i + 1, hit.point);//렌더러 보이게한다.
                    }
                }
                else
                {//충돌하지 않았다면
                 /* inDirection = Vector3.Reflect(inDirection, hit.normal);//방향 지정
                  ray = new Ray(hit.point, inDirection);

                  lineRenderer.positionCount = ++nPoints; //지점의 갯수 늘리고
                  lineRenderer.SetPosition(i + 1, inDirection * 5000);//렌더러 앞으로 보이게한다.*/
                    lineRenderer.SetPosition(i + 1, transform.forward * 5000);
                }
            }
        }

	}
}
