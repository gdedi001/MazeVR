using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

    //Create a reference to the KeyPoofPrefab and Door
    public GameObject Door;
    public GameObject Effect;

	public void OnKeyClicked()
	{
        Vector3 keyLocation = gameObject.transform.position;

        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        Instantiate(Effect, new Vector3(keyLocation.x, keyLocation.y, keyLocation.z), transform.rotation );
        // Call the Unlock() method on the Door
        Door.GetComponent<Door>().Unlock();
        // Destroy the key. Check the Unity documentation on how to use Destroy
        Destroy(gameObject);
    }

}
