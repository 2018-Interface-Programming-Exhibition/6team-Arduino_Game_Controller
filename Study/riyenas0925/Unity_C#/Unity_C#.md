## 유니티 화면 구성 요소
* 하이에라키 뷰(Hierachy View)
    * 게임 오브젝트(Game Object)의 목록
    * 처음 프로젝트를 생성하면 메인카메라(Main Camera) + 디렉셔널 라이트(Directional Light) 두가지가 있다.
>
* 신 뷰(Scene View)
    * 게임 오브젝트의 배치를 보여줌
>
* 게임 뷰(Game View)
    * 신뷰를 촬영해서 보여줌
>
* 프로젝터 뷰(Projector View)
    * 프로젝트 구성 파일을 보여줌
>
* 콘솔 뷰(Console View)
    * 로그를 확인할수 있음
>
* 인스펙터 뷰(Inspector View)
    * 게임의 구성요소들에 대한 자세한 정보 표시
    * EX) 트랜스 폼(Transform)
        * 포지션(Position)은 현재 좌표
            * y축이 높이를 나타낸다.(기존의 x,y,z(높이)가 아님.
        * 로테이션(Rotation)은 기울기
        * 스케일(Scale)은 크기를 나타낸다
>
---

## 게임 오브젝트
* 게임 오브젝트(Game Object)
    * 게임 실행하면 나오는 여러 구성요소
        * 플레이어, 장애물, 게임 배경 등
>
* 게임 오브젝트를 조작하는 방법
    1. 배경이동(Q) - 배경이동
        * 드래그 클릭으로도 가능
    2. 이동(W) -  게임오브젝트 이동
    3. 회전(E) - 게임오브젝트 회전
    4. 늘이기(R) 게임오브젝트를 축소 / 확대
>
* 카메라(Camera) - Object
    * 신뷰에 배치되어 있는 게임 오브젝트를 찍어서 게임 뷰에서 보여주는 역할을 한다.
>
* 라이트(Light) - Object
    * 광원효과를 내는 오브젝트이다.
    * EX) Directional Light는 한쪽 방향으로 빛을 쏜다

---

## 컴포넌트

* 컴포넌트(Component)
    * 컴포넌트는 게임 오브젝트의 성질을 결정한다.
        * EX) Main Camera는 Camera라는 컴포넌트를 가진다.
        * Camera 컴포넌트가 없으면 카메라 역할을 못한다.
    * Add Component를 통해 컴포넌트를 추가할수 있다.

---

## 유니티 물리 엔진
> 용어(기능) - 적용대상
> Component는 Add Component를 통해 적용
> Collider은 Collider에 드래그해서 적용

* Rigid Body(물리법칙) - Component
    * 추가하면 오브젝트에 물리법칙을 적용한다.
        * EX) Use Gravity : 중력을 적용할지 여부

>
* Pysics Material(물성) - Collider
    * 우클릭 Create - Physic Material
    * 파일생성후 Collider에 드래그해서 적용
        * EX) Dynamic Friction : 운동 마찰력
        * EX) Static Friction : 정지 마찰력
        * EX) Bounce Combine : Max 설정시 힘감소 X, 공이 계속 튀어 오른다.
>
* Collider(충돌감지) - Component
    * Sphere는 Sphere Collider
    * Cube는 Box Collider
    * Center의 값을 변경하여 Collider의 위치를 조절할수 있다.
    * Radius의 값을 변경하여 Collider의 반경을 조절할수 있다.