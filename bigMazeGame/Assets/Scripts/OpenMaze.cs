using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMaze : MonoBehaviour
{
    public GameObject exitWall; // The wall to be moved to release the player

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
        exitWall.transform.Translate(-3.2f, 0f, 0f); // Move the wall to release the player

        print("Well done on finding the key\nNow you just have to find your way out\nIt might not be the same way you got here…");

        /* 
         * The following code was researched at the following location:
         * Unity Technologies, 2021. Unity Documentation Version 2020.3.
         * Accessed at: https://docs.unity3d.com/ScriptReference/Object.Destroy.html [Accessed 10/11/21].
         * 
         * The code was not copied word for word, it was merely used as a
         * guide to understand the Destroy method and how to use it and what
         * to pass in to destroy the game object the script is attached to.
         */
        Destroy(gameObject); // Remove the key from the game
    }
}
