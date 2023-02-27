using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class  Star : MonoBehaviour
{
    
    public float rotateSpeed;
    public float RotateSpped
    {
        get {
            if (rotateSpeed == 0)
            {
                return -10;
            }
            return rotateSpeed;
        }
       
    }
    


    protected virtual void ratation()
    {
        transform.Rotate(0, RotateSpped * Time.deltaTime, 0);
    }



}
