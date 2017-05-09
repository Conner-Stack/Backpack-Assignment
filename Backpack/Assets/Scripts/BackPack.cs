using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackPack : MonoBehaviour {
    //the entire nested list for a backpack using 2 columns with x number of rows.
    List<List<Item>> inventory;
    //the list of every item taking up a slot in the backpack, seperated into the columns above
    public List<Item> invSlots;
    //how many slots are contained in the backpack
    public int slots;
    //how many rows per column
    public int rows;
    //the gameobject the backpack will be attached to.
    GameObject player;
    /*a function stating that if an item collides with the player, pressing a button will add it to the
    backpack */
    public void AddItem(Item item)
    {
        /*conditional nested stating that if above is true, and if the item takes up less slots
         to add it to the list*/
        if (item.slotUsage < slots)
            invSlots.Add(item); //populates the needed number of slots in the inventory
        else
            Debug.Log("not enough slots in inventory");/*if there are not enough slots, 
                sends a string message to the console*/


    }
    /*a function used to get the amount of space in the inventory, maybe not be needed */
    int GetInv(List<Item> itemList)
    {
        itemList = invSlots;
        int empty = new int();
        for(int i = 0; i < slots; i++)
        {
            if (itemList[i] == null)
                empty += 1;
        }
        return empty;
    }
    void useItem(Item item)
    {

    }

	// Use this for initialization
	void Start () {
        inventory = new List<List<Item>>(rows);
        invSlots = new List<Item>(slots);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
