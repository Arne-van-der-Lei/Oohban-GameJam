using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    enum sides
    {
        Top,
        Right,
        Left,
        Bottom
    }

    public string Name = "Air";
    public bool TopInput = true;
    public bool RightInput = false;
    public bool LeftInput = false;
    public bool RightOutput = false;
    public bool LeftOutput = false;
    public bool BottomOutput = true;

    public float MaxWaterAmount = 1.0f;
    public float MaxWaterFlow = 0.2f;

    protected float WaterAmount = 0.0f;
    private MeshRenderer Renderer;

    // Use this for initialization
    void Start () {
        Renderer = GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Renderer != null)
        {
            Renderer.material.color = new Color(WaterAmount, WaterAmount, WaterAmount, 1.0f);
        }
	}

    void AddWater(sides sideInput, float amount)
    {
        if (CheckInput(sideInput))
        {
            if (WaterAmount + amount > MaxWaterAmount)
            {
                WaterAmount = MaxWaterAmount;
            }else
            {
                WaterAmount += amount;
            }

            if (WaterAmount >= MaxWaterAmount/2.0f)
            {
                UpdateSides();
            }
        }
    }

    bool CheckInput(sides side)
    {
        switch (side)
        {
            case sides.Top:
                if (TopInput) return true;
                break;
            case sides.Right:
                if (RightInput) return true;
                break;
            case sides.Left:
                if (LeftInput) return true;
                break;
        }
        return false;
    }

    protected void UpdateSides()
    {
        int amountOfOutputs = 0;
        if (LeftOutput) amountOfOutputs++;
        if (RightOutput) amountOfOutputs++;
        if (BottomOutput) amountOfOutputs++;

        if (amountOfOutputs == 0) return;

        float amountToOutput = MaxWaterFlow / amountOfOutputs;

        if (LeftOutput) {
            Block block = World.Instance.GetBlock((int)(transform.position.x  - World.Instance.offset.x) - 1, (int)(transform.position.y - World.Instance.offset.y), (int)(transform.position.z - World.Instance.offset.z));
            if (block != null) block.AddWater(sides.Right, amountToOutput);
        }
        if (RightOutput)
        {
            Block block = World.Instance.GetBlock((int)(transform.position.x - World.Instance.offset.x), (int)(transform.position.y - World.Instance.offset.y), (int)(transform.position.z  - World.Instance.offset.z) - 1);
            if (block != null) block.AddWater(sides.Left, amountToOutput);
        }
        if (BottomOutput)
        {
            Block block = World.Instance.GetBlock((int)(transform.position.x - World.Instance.offset.x), (int)(transform.position.y - World.Instance.offset.y) - 1, (int)(transform.position.z - World.Instance.offset.z));
            if (block != null) block.AddWater(sides.Top, amountToOutput);
        }
        WaterAmount -= MaxWaterFlow;
    }
}
