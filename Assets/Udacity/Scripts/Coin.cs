using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    // Create a reference to the CoinPoofPrefab
    public GameObject Effect;

    private static int coinsCollected = 0;

    public int CoinsCollected {
        get {
            return coinsCollected;
        }
        set {
            coinsCollected = value;
        }
    }

    public void OnCoinClicked() {
        Vector3 coinLocation = gameObject.transform.position;
        
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        Instantiate(Effect, new Vector3(coinLocation.x, coinLocation.y, coinLocation.z), Quaternion.Euler(-90f, 0, 0));
        // Update the amount of Coins collected
        CoinsCollected++;
        // Destroy this coin. Check the Unity documentation on how to use Destroy
        Destroy(gameObject);
    }
}
