using UnityEngine;

namespace UnityStandardAssets.Characters.FirstPerson
{
    public class GMscript : MonoBehaviour
    {

        public CanvasGroup invenCG;//인벤 켄버스그룹 구성성분 저장변수
        public GameObject FPC;//캐릭터 컨트롤러 지정변수
        public bool Cvision;//커서 보이게 하는 변수,락도 설정함.
        public bool mouse;//마우스커서 컨트롤변수
        public GameObject ReturnHome;//홈화면으로 돌아가기

        void Start()
        {
            InvenOpen(false);
            Cvision = false;

            mouse = true;





        }

        // Update is called once per frame
        void Update()
        {

            if (Input.GetKeyDown(KeyCode.I))
            {
                if (invenCG.alpha == 0)
                {
                    InvenOpen(true);
                    mouse = false;
                    Cvision = true;
                }
                else
                {
                    InvenOpen(false);
                    mouse = true;
                    Cvision = false;
                }
            }
            if (Cvision)
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }
        public void InvenOpen(bool open)//인벤 활성/비활성화 함수
        {
            invenCG.alpha = (open) ? 1.0f : 0.0f;
            invenCG.interactable = open;
            invenCG.blocksRaycasts = open;
            
        }
    }
}