using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SignPost : MonoBehaviour {
    public GameObject Canvas;
    public GameObject CollectedItem;

    Text txt;

    void Update() {
        txt = Canvas.GetComponent<Text>();
        txt.text = "YOU WIN!\nCoins Collected: " + CollectedItem.GetComponent<Coin>().CoinsCollected + "/15";
    }

    public void ResetScene() {
        // Reset the scene when the user clicks the sign post
        SceneManager.LoadScene("Maze");
	}
}