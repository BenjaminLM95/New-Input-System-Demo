using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame) 
        {
            Debug.Log("Space Button was pressed"); 
        }

        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            Debug.Log("The 'A' key was pressed");
        }

    }
}
