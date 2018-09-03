using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private Transform itemTr;
    private Transform inventory;
    private Transform Holdingitem;
    private CanvasGroup canvasGroup;
    private Transform Slot;

    public static GameObject draggingItem = null;

    
    void Start()
    {
        itemTr = GetComponent<Transform>();
        inventory = GameObject.Find("Inventory").GetComponent<Transform>();
        
        Slot = GameObject.Find("slot").GetComponent<Transform>();

        Holdingitem = transform.parent;
        
        canvasGroup = GetComponent<CanvasGroup>();
    }


    public void OnDrag(PointerEventData eventData)
    {
        //마우스가 아이템을 끌어들이게 변경.
        itemTr.position = Input.mousePosition;
    }


    public void OnBeginDrag(PointerEventData eventData)
    {
        //인벤토리로 부모 갈아타기
        this.transform.SetParent(inventory);
        //아이탬정보 저장
        draggingItem = this.gameObject;
        //다른 이벤트 차단
        canvasGroup.blocksRaycasts = false;
        
       
    }


    public void OnEndDrag(PointerEventData eventData)
    {
        //저장했던 정보 삭제
        draggingItem = null;
        //다른 이벤트 활성화
        canvasGroup.blocksRaycasts = true;

        //슬롯에 놓은게 아니면 원래 제자리로 돌려보냄.
        if ((itemTr.parent == inventory))
        {
            itemTr.SetParent(Holdingitem.transform);
        }
    }
}