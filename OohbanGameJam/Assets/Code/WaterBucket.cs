using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBucket : WaterChanger {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void ChangeMesh(float value, Block.sides side)
    {
        transform.rotation = Quaternion.Euler(new Vector3(-90, 90, 0));
        if (value >= 0.5f)
        {
            MeshFiter.mesh = mesh25;
        }
        else if(value >= 0.25f)
        {
            MeshFiter.mesh = mesh50;
        }
    }
}
