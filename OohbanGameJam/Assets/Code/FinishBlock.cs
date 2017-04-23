﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishBlock : Block {

    // Use this for initialization
    protected override void Start () {
        base.Start();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    protected override void OnChangeWater()
    {
        if(WaterAmount >= 0.5f)
        {
            World.Instance.LevelEnd();
        }
    }
}
