using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraScript : MonoBehaviour
{

    Vector2 lookDirection;
    public GameObject player;

    public void LookDireaction(InputAction.CallbackContext callback)
    {
        if (callback.started)
        {
           
            lookDirection = callback.ReadValue<Vector2>();

        }
        else if (!callback.started)
        {
            lookDirection = callback.ReadValue<Vector2>();
        }

    }
    private void Look()
    {
        transform.Rotate(new Vector3(-lookDirection.y,0 , 0),Space.Self);
        player.transform.Rotate(0, lookDirection.x, 0);
    }

   

    // Update is called once per frame
    void Update()
    {
        Look();
    }
}
