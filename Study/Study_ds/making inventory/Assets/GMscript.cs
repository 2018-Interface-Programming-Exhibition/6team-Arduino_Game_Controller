using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class GMscript : MonoBehaviour {
    public GameObject ItemMessage; 
    public CanvasGroup invenCG;//인벤 켄버스그룹 구성성분 저장변수
    public GameObject FPC;//캐릭터 컨트롤러 지정변수
    public bool Cvision;//커서 보이게 하는 변수,락도 설정함.
    public FirstPersonController firstPersonController;
    public Camera maincamera;

    
void Start () {
        InvenOpen(false);
        Cvision = false;
        ItemMessage.active = false;
        maincamera.enabled = true;
        
        
        
            
	}
	
	// Update is called once per frame
	void Update () {
        maincamera.enabled = true;
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (invenCG.alpha == 0)
            {
                InvenOpen(true);
                firstPersonController.enabled = false;
                Cvision = true;
            }
            else
            {
                InvenOpen(false);
                firstPersonController.enabled = true;
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
