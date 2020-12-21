using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class DragItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject ItemBeginDragged;
    public static DragItem instance;
    Vector3 startPos;
    Transform startParent;
    public Itens Item;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Image>().sprite = Item.ImgItem;
    }

    // Update is called once per frame

    public void DestroyObject()
    {
        if (Item.ItemType.ToString() == "Potion")
        {
            Item.GetAction();
            Destroy(gameObject);
        }

    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        ItemBeginDragged = gameObject;
        startPos = transform.position;
        startParent = transform.parent;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;   
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        ItemBeginDragged = null;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        if (transform.parent == startParent)
        {
            transform.position = startPos;
        }
    }
    public void setParent(Transform slotTransform, Slot slots)
    {
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        if (Item.SlotType.ToString() == slots.SlotType.ToString())
        {
            transform.SetParent(slotTransform);
            if (!PlayerController.instance.verify)
                Item.GetAction();

        }else if (slots.SlotType.ToString() == "none")
        {
            transform.SetParent(slotTransform);
            if(PlayerController.instance.verify)
            Item.RemoveStatus();
     
        }
    }
}
