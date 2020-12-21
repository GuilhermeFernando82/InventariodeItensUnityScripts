using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject SlotParent;
    public List<Slot> slot = new List<Slot>();
    public static Inventory instance;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }
    public void Start()
    {
        GetSlot();
    }
    public void GetSlot()
    {
        foreach(Slot s in SlotParent.GetComponentsInChildren<Slot>())
        {
            slot.Add(s);
        }
        //CreateItem();
    }  
    public void CreateItem(Itens item)  
    {
        foreach(Slot s in slot)
        {
            if(s.transform.childCount == 0)
            {
                GameObject CurrentItem = Instantiate(GameController.instance.ItemPrefab, s.transform);
                CurrentItem.GetComponent<DragItem>().Item = item;

                return;

            }
        }
      
    }
    public void RemoveItem(Itens item)
    {
        foreach (Slot s in slot)
        {
            if (s.transform.childCount == 0)
            {
                GameObject CurrentItem = Instantiate(GameController.instance.ItemPrefab, s.transform);
                CurrentItem.GetComponent<DragItem>().Item = item;
                CurrentItem.SetActive(false);
                return;

            }
        }

    }

}
