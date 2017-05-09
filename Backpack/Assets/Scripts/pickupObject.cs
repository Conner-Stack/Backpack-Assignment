using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupObject : MonoBehaviour {

    public TestScriptableObject myObject;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(myObject.test);
       if(other.GetComponent<BackPack>())
        {
            other.GetComponent<BackPack>().AddItem(GetComponent<Item>());
        }         
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
