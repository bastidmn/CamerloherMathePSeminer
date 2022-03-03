using System;
using Unity.VisualScripting;
using UnityEngine;

namespace Controller
{
    public class InputController : MonoBehaviour
    {
        private void FixedUpdate()
        {
            if (Input.GetKey(KeyCode.W))
            {
                GameController.Instance.Forward();
            }

            if (Input.GetKey(KeyCode.S))
            {
                GameController.Instance.Backward();
            }
            if (Input.GetKey(KeyCode.A))
            {
                GameController.Instance.Left();
            }
            if (Input.GetKey(KeyCode.D))
            {
                GameController.Instance.Right();
            }
            if (Input.GetKey(KeyCode.Space))
            {
                GameController.Instance.Jump();
            }
            if (Input.GetKey(KeyCode.E))
            {
                GameController.Instance.Interact();
            }
            if (Input.GetKey(KeyCode.Escape))
            {
                GameController.Instance.OpenPauseMenu();
            }
            if (Input.GetKey(KeyCode.P))
            {
                GameController.Instance.ToogleBackgroundMusic();
            }
            if (Input.GetKey(KeyCode.Escape) && Input.GetKey(KeyCode.LeftShift))
            {
                GameController.Instance.EndGame();
            }
        }
    }
    
}

enum Controls
{
    Forward,
    Backward,
    Left,
    Right,
    Jump,
    Interact,
    PauseMenu,
    ToggleMusic,
    EndGame,
}