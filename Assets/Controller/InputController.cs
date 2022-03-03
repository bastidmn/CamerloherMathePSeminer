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
            }
            if (Input.GetKey(KeyCode.S))
            {
            }
            if (Input.GetKey(KeyCode.A))
            {
            }
            if (Input.GetKey(KeyCode.D))
            {
            }
            if (Input.GetKey(KeyCode.Space))
            {
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