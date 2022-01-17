using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeEscaped : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        print("Congratulations! You free yourself from my labrynth\nNext time I won't make things so easy…");

        /* 
         * The following code was researched at the following location:
         * Unity Technologies, 2021. Unity Documentation Version 2020.3.
         * Accessed at: https://docs.unity3d.com/ScriptReference/Object.Destroy.html [Accessed 10/11/21].
         * 
         * The code was not copied word for word, it was merely used as a
         * guide to understand the Destroy method and how to use it and what
         * to pass in to destroy the game object the script is attached to.
         */
        Destroy(gameObject); // Remove the trigger cube so that it isn't used twice
    }
}
