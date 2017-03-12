using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{

    //Create a reference to the KeyPoofPrefab and Door
    public GameObject Door;
    public GameObject Effect;

    bool collected = false;

	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
        
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        //Instantiate.
        Object.Instantiate(Effect, new Vector3(-8.34f, 2.644f, 106.88f), Quaternion.identity);
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
        //Door.
        // Set the Key Collected Variable to true
        collected = true;
        // Destroy the key. Check the Unity documentation on how to use Destroy
        Destroy(this.gameObject);
    }

}
