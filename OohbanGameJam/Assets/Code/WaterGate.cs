using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterGate : WaterChanger {

    public bool Ison = false;

    private void Update()
    {
    }

    public override void ChangeMesh(float value, Block.sides side)
    {
        if(Ison)
        {
            transform.rotation = Quaternion.Euler(-90, 0, 90);
        }
        else
        {
            transform.rotation = Quaternion.Euler(-90, 0, 0);
        }

        if (value >= 1.00f)
        {
            MeshFiter.mesh = mesh100;
            transform.Rotate(0, 0, 180);
        }
        else if (value >= 0.75f)
        {
            MeshFiter.mesh = mesh75;
            transform.Rotate(0, 0, 180);
        }
        else if (value >= 0.50f)
        {
            MeshFiter.mesh = mesh50;
        }
        else if (value >= 0.25f)
        {
            MeshFiter.mesh = mesh25;
            transform.Rotate(-90, 0, 0);
        }
    }
}
