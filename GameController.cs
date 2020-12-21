using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject inventory;
    public GameObject buttonInventory;
    public GameObject ItemPrefab;
    public static GameController instance;
    void Awake()
    {
        instance = this;    
    }
    // Start is called before the first frame update
    public void AtiveInventory(GameObject GO)
    {
        GO.SetActive(true);
        buttonInventory.SetActive(false);
    }
    public void ExitInventory(GameObject GO)
    {
        GO.SetActive(false);
        buttonInventory.SetActive(true);
    }
   
   
}
