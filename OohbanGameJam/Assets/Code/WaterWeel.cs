using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterWeel : LeverSwitcher {

    public bool Force = false;
    public bool Invert = false;
    private bool HasSetToTrue = false;
    

    private void Update()
    {
        if (World.Instance.GetBlock((int)transform.position.x,(int)transform.position.y-1,(int)transform.position.z).WaterAmount >= 0.1 && !HasSetToTrue)
        {
            gate.IsOn = !Invert;
            if (!Force)
            {
                HasSetToTrue = true;
            }
        }
        else if(!HasSetToTrue)
        {
            gate.IsOn = Invert;
        }
    }
}
