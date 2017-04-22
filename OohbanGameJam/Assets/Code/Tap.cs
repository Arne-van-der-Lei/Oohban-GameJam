using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tap : Block {

    public float UpdateTime = 1.0f;
    float counter = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        counter += Time.deltaTime;

        if(counter >= UpdateTime)
        {
            WaterAmount = MaxWaterAmount;
            counter -= UpdateTime;
            UpdateSides();
        }
	}
}
