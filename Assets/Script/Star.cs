using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class  Star : MonoBehaviour
{
   
    public float ratateSpeed;


    protected virtual void ratation()
    {
        transform.Rotate(0, ratateSpeed * Time.deltaTime, 0);
    }



}
