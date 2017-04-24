using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterAir : WaterChanger {

     
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    override public void ChangeMesh(float value, Block.sides side)
    {
        if(side  == Block.sides.Right)
        {
            transform.rotation = Quaternion.Euler(new Vector3(-90, 180, 0));
            if (value >= 0.5f)
            {
                transform.rotation = Quaternion.Euler(new Vector3(-90, 180, 180));
                MeshFiter.mesh = mesh50;
            }
            else if(value >= 0.25f)
            {
                MeshFiter.mesh = mesh25;
            }
        }
        else if(side == Block.sides.Left)
        {
            transform.rotation = Quaternion.Euler(new Vector3(-90, 90, 0));
            if (value >= 0.5f)
            {
                transform.rotation = Quaternion.Euler(new Vector3(-90, 90, 180));
                MeshFiter.mesh = mesh50;
            }
            else if (value >= 0.25f)
            {
                MeshFiter.mesh = mesh25;
            }
        }
        else if(side == Block.sides.Top)
        {
            if (value >= 0.5f)
            {
                MeshFiter.mesh = mesh100;
            }
            else if (value >= 0.25f)
            {
                MeshFiter.mesh = mesh75;
            }
        }
    }
}
