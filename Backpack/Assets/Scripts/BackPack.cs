using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackPack : MonoBehaviour {
    List<List<Item>> inventory;
    List<Item> invSlots;
    public int slots;
    public int rows;
    GameObject player;
    void AddItem(Item item)
    {
        while (player.GetComponent<Collider>() && item.GetComponent<Collider>())
        {
            if (Input.GetKeyDown("e") || Input.GetKeyDown("E"))
            {
                if (item.slotUsage < inventory.Capacity)
                    invSlots.Add(item);
                else
                    Debug.Log("not enough slots in inventory");

            }
            
        }

    }
    void getinv()
    {
        for(int i = 0; i < slots; i++)
        {
            if (invSlots[i] != null)
            {
                if (invSlots[i].slotUsage == 2)
                    Debug.Log(invSlots[i].name + " occupying slots " + i.ToString() + " and " + 
                        i.ToString() + 1);
                else
                    Debug.Log(invSlots[i].name + "occupying slot " + i.ToString());
            }
            else
                Debug.Log("slot empty");
        }
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
