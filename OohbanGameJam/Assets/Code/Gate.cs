using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour {

    public Block block;
    public WaterGate water;
    public bool IsOn = false;

    public bool LeftBackOn = false;
    public bool RightBackOn = false;
    public bool LeftFrontOn = false;
    public bool RightFrontOn = false;

    public bool LeftBackOff = false;
    public bool RightBackOff = false;
    public bool LeftFrontOff = false;
    public bool RightFrontOff = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (IsOn)
        {
            block.LeftInput = LeftBackOn;
            block.RightInput = RightBackOn;
            block.LeftOutput = LeftFrontOn;
            block.RightOutput = RightFrontOn;
            transform.localRotation = Quaternion.Euler(-90, 90, 0);
            water.Ison = true;
        }
        else
        {
            block.LeftInput = LeftBackOff;
            block.RightInput = RightBackOff;
            block.LeftOutput = LeftFrontOff;
            block.RightOutput = RightFrontOff;
            transform.localRotation = Quaternion.Euler(-90, 0, 0);
            water.Ison = false;
        }

	}
}
