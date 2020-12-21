using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class PotionHP : MonoBehaviour
{
    public float ColliderRadius;
    public List<Itens> Item = new List<Itens>();
    public GameObject BoxMsg;
    public TextMeshProUGUI msg;

    public bool isTake = true;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void open()
    {
        foreach (Itens i in Item)
        {
           
            Inventory.instance.CreateItem(i);
            Destroy(gameObject);
            // Inventory.instance.CreateItem(i);

        }
    }
  

    public void OnTriggerStay2D(Collider2D collision)
    {
        msg.text = "Legal Fera!!!";
        BoxMsg.SetActive(true);
        open();
       
        AudioController.corrent.PlayMusic(AudioController.corrent.sfx);
        //if (collision.gameObject.CompareTag("Player") && Input.GetKeyUp(KeyCode.E))
        //{



        //}

    }
   
}
