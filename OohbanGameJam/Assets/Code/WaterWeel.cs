using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterWeel : LeverSwitcher {

    
    private void Update()
    {
        if (World.Instance.GetBlock((int)transform.position.x,(int)transform.position.y-1,(int)transform.position.z).WaterAmount >= 0.5)
        {
            gate.IsOn = true;
        }
        else
        {
            gate.IsOn = false;
        }
    }
}
