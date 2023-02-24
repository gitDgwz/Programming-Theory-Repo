using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    Vector2  moveDirection;
  
    float JumpDireaction;
    public  float speed;



    public void MoveDireaction(InputAction.CallbackContext callback)
    {
        if (callback.started)
        {
            moveDirection = callback.ReadValue<Vector2>();
           
        }
        else if (!callback.started)
        {
            moveDirection = callback.ReadValue<Vector2>();
        }
      
    }

    public void jump(InputAction.CallbackContext callback)
    {
        if (callback.started)
        {
            JumpDireaction = callback.ReadValue<float>();
        }
        else if (!callback.started)
        {
            JumpDireaction = callback.ReadValue<float>();
        }

    }
   



    private void Move()
    {
        transform.Translate(new Vector3(moveDirection.x*Time.deltaTime* speed, JumpDireaction * Time.deltaTime * speed, moveDirection.y*Time.deltaTime * speed));
    }



    // Update is called once per frame
    void Update()
    {
        Move();  
    }
}
