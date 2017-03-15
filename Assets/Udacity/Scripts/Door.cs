using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour  {

    public AudioClip[] soundFiles;
    public AudioSource soundSource;

    // Create a boolean value called "locked" that can be checked in OnDoorClicked()
    bool locked = true;
    // Create a boolean value called "opening" that can be checked in Update() 
    bool opening = false;

    private string objectToFind = "Door";
    private float fullHeight = 8.0f;

    void Update() {
        // If the door is opening and it is not fully raised
        if (opening && transform.position.y < fullHeight) {
            // Animate the door raising up
            transform.Translate(0, 2.5f * Time.deltaTime, 0);
            Debug.Log(opening.ToString());
        }

    }

    public void OnDoorClicked() {

        // If the door is clicked and unlocked
        if (!locked) {
            soundSource.clip = soundFiles[1];
            soundSource.Play();
            opening = true;
        }
        else {
            soundSource.clip = soundFiles[0];
            soundSource.Play();
        }
    }

    public void Unlock() {
        // You'll need to set "locked" to false here
        locked = false;
    }
}
