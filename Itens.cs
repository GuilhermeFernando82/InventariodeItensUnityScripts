using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class Itens : ScriptableObject
{
	public string nameItem;
	public Sprite ImgItem;
	public float value;
	public PlayerController player1;
	public List<Itens> Item = new List<Itens>();
	void Start () {
		
	}
	[System.Serializable]
	public enum SlotsType
	{
		helmet,
		shild,
		armor
	}

	public SlotsType SlotType;
	[System.Serializable]
	public enum Type
    {
		Potion,
		Espada,
		Equipe
    }
	public Type ItemType;

	public void Destroc()
    {
		Debug.Log("OK");
		foreach (Itens i in Item)
		{

			Inventory.instance.RemoveItem(i);
			Debug.Log("OK");
			
			// Inventory.instance.CreateItem(i);

		}
	}

	public void GetAction()
    {
		player1 = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        switch (ItemType)
        {
			case Type.Potion:
				player1.StatusAdd(value,0);
				break;
			case Type.Espada:
				player1.StatusAdd(0, 2);
				break;
			case Type.Equipe:
				Debug.Log("Funcionou Equipe");
				break;


		}
	}
	public void RemoveStatus()
	{
		player1 = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
		switch (ItemType)
		{
			case Type.Potion:
				player1.StatusRemove(value,0);
				break;
			case Type.Espada:
				player1.StatusRemove(0, 2);
				break;
			case Type.Equipe:
				Debug.Log("Funcionou Equipe");
				break;


		}
	}
	

	/*public virtual void usar(){
				if(this.name == "Potion")
				{
					PlayerController.instance.vida = 100;
					InventoryControll.instance.RemoveItemPerma(this);
				}else{
					
				}
				
	}
	
	public void RemoveI(){
		InventoryControll.instance.RemoveItem (this);
		
	}
	/*public void AddItem(int amountToAdd = 1){
		amount += amountToAdd;
	}*/

	// Update is called once per frame
	/*void Update () {
		if (Input.GetKeyDown(KeyCode.Alpha1) && canTakeItem){
			teste = true;
			print ("Entrou");
			InventoryControll.instance.AddIten(this);

		}
	}*/
	/*public int GetAmount(){

		return amount;
	}*//*
	public void OnTriggerStay2D(Collider2D other){
		if (other.gameObject.CompareTag ("Player")) {
			canTakeItem = true;
		}
	}
	public void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.CompareTag ("Player")) {
			canTakeItem = false;
		}
	}*/
}
