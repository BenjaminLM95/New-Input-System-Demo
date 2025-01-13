using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour, GameInput.IGameplayActions
{
    public GameInput gameInput;

    void Start()
    {        
        gameInput = new GameInput();
        gameInput.Gameplay.Enable();
        gameInput.Gameplay.SetCallbacks(this);
    }

    public void OnJump(InputAction.CallbackContext context)
    {                  
        
        if(context.performed)
        { 
            Debug.Log("Jump button is pressed!");
            //JumpEvent?.Invoke(); 
        }

        if (context.started)
        {
            Debug.Log("You start jumping");
        }

        if (context.canceled) 
        {
            Debug.Log("You cancelled the jump"); 
        }

    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        
    }
          

    #region public actions

    private Action JumpEvent;

    #endregion

  

}
