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
    // estimates how high the door must be raised when opening
    private float fullHeight = 8.0f;

    void Update() {
        // If the door is opening and it is not fully raised
        if (opening && transform.position.y < fullHeight) {
            // Animate the door raising up
            transform.Translate(0, 2.5f * Time.deltaTime, 0);
        }

    }

    public void OnDoorClicked() {
        int doorLocked = 0;
        int doorOpen = 1;

        // If the door is clicked and unlocked
        if (!locked) {
            soundSource.clip = soundFiles[doorOpen];
            soundSource.Play();
            opening = true;
        }
        else {
            soundSource.clip = soundFiles[doorLocked];
            soundSource.Play();
        }
    }

    public void Unlock() {
        // You'll need to set "locked" to false here
        locked = false;
    }
}
