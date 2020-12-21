using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rmitem : MonoBehaviour
{
    public GameObject obj;
    public PlayerController player1;
    // Start is called before the first frame update
    public Itens Item;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DestroyObject()
    {
        if(Item.ItemType.ToString() == "Potion")
        {
            //player1.StatusAdd(20, 0);
            Destroy(gameObject);
        }
        
    }
}
