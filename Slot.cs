using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{
    // Start is called before the first frame update
    [System.Serializable]
    public enum SlotsType
    {
        none,
        helmet,
        shild,
        armor
    }
    public SlotsType SlotType;
    public GameObject item
    {
        get
        {
            if(transform.childCount > 0)
            {
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }
    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            DragItem.ItemBeginDragged.GetComponent<DragItem>().setParent(transform, this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
