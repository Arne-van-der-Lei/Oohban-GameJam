using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishBlock : Block {

    // Use this for initialization


    public void Update()
    {
        if (WaterAmount >= 0.5f)
        {
            World.Instance.LevelEnd();
        }
    }
}
