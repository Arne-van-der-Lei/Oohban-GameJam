using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tap : Block {

    public float UpdateTime = 1.0f;
    float counter = 0.0f;
    public bool IsOn = false;
    
	
	// Update is called once per frame
	void Update () {
        if (IsOn)
        {
            counter += Time.deltaTime;

            if (counter >= UpdateTime)
            {
                WaterAmount = MaxWaterAmount;
                counter -= UpdateTime;
                UpdateSides();
            }
        }
	}

    public void OnClick()
    {
        IsOn = !IsOn;
        Update();
        Debug.Log("Clicked");
    }
}
