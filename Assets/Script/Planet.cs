using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : Star
{

    public float revolutionSpeed;
    





    protected virtual  void revolution()
    {
        transform.RotateAround(Vector3.zero, Vector3.down, revolutionSpeed*Time.deltaTime);
    }

    private void Update()
    {
        ratation();
        revolution();
    }
}
