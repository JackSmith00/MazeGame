using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMazeGame : MonoBehaviour
{
    public GameObject entranceWall; // The wall to be moved to trap the player

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        entranceWall.transform.Translate(3.2f, 0f, 0f); // Move the wall to trap the player
        /*
         * Ideally I would like this door to slide shut, however, for now
         * translating the position will be good enough
         */

        print("You are now trapped in the labrynth\nTo escape, you must first find the key hidden within these walls…");

        /* 
         * The following code was researched at the following location:
         * Unity Technologies, 2021. Unity Documentation Version 2020.3.
         * Accessed at: https://docs.unity3d.com/ScriptReference/Object.Destroy.html [Accessed 10/11/21].
         * 
         * The code was not copied word for word, it was merely used as a
         * guide to understand the Destroy method and how to use it and what
         * to pass in to destroy the game object the script is attached to.
         */
        Destroy(gameObject); // Remove the entrace trigger so this action is not repeated
    }
}
