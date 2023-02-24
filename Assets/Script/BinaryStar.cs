using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinaryStar : Planet
{
    public GameObject MainPlanet;

    

    protected override void  revolution()
    {
        transform.RotateAround(MainPlanet.transform.position, Vector3.down, revolutionSpeed * Time.deltaTime);
    }

    private void Update()
    {
        revolution(); ;
    }
}
