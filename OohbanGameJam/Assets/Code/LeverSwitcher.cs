﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverSwitcher : MonoBehaviour {

    public Gate gate;
    public GameObject HandelOn;
    public GameObject HandelOff;

    public void OnClick()
    {
        gate.IsOn = !gate.IsOn;

        if (gate.IsOn)
        {
            HandelOn.SetActive(true);
            HandelOff.SetActive(false);
        }else
        {
            HandelOn.SetActive(false);
            HandelOff.SetActive(true);
        }
    }
}
