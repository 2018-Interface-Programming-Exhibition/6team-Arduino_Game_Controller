using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMscript : MonoBehaviour {

    public CanvasGroup invenCG;//인벤 켄버스그룹 구성성분 저장변수
	void Start () {
        InvenOpen(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void InvenOpen(bool open)//인벤 활성/비활성화 함수
    {
        invenCG.alpha = (open) ? 1.0f : 0.0f;
        invenCG.interactable = open;
        invenCG.blocksRaycasts = open;
    }
}
