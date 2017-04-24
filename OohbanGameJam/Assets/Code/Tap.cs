using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tap : Block {

    public float UpdateTime = 1.0f;
    float counter = 0.0f;
    public bool IsOn = false;
    
	
	// Update is called once per frame
	void Update () {
        
        counter += Time.deltaTime;

        if (counter >= UpdateTime)
        {
            if (IsOn)
            {
                waterAmount = MaxWaterFlow;
            }
            counter -= UpdateTime;
            if (WaterAmount >= 0)
            {
                UpdateSides();
            }
        }
}

    public void OnClick()
    {
        IsOn = !IsOn;
        UpdateSides();
        Debug.Log("Clicked");
    }
}
