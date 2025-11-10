using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    public InputAction LeftAction;
    public InputAction MoveAction;
    void Start()
    {
        //QualitySettings.vSyncCount = 0;
        //Application.targetFrameRate = 10;
        LeftAction.Enable();
        MoveAction.Enable();
    }


    void Update()
    {
        float horizontal = 0.0f;
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            horizontal = -1.0f;
        }
        else if (Keyboard.current.rightArrowKey.isPressed)
        {
            horizontal = 1.0f;
        }
        Debug.Log(horizontal);


        float vertical = 0.0f;
        if (Keyboard.current.upArrowKey.isPressed)
        {
            vertical = 1.0f;
        }
        else if (Keyboard.current.downArrowKey.isPressed)
        {
            vertical = -1.0f;
        }
        Debug.Log(vertical);

        Vector2 move = MoveAction.ReadValue<Vector2>();
        Debug.Log(move);
         Vector2 position = (Vector2)transform.position + move * 3.0f * Time.deltaTime;
        position.x = position.x + 0.1f * horizontal;
        position.y = position.y + 0.1f * vertical;
        transform.position = position;
        {
            


        }
    }
}