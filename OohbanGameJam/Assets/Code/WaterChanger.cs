using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterChanger : MonoBehaviour {

    public Mesh mesh25;
    public Mesh mesh50;
    public Mesh mesh75;
    public Mesh mesh100;

    public MeshFilter MeshFiter;
    // Use this for initialization
    void Start () {
        MeshFiter = GetComponent<MeshFilter>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    virtual public void ChangeMesh(float value,Block.sides side)
    {
        if (value >= 1.00f)
        {
            MeshFiter.mesh = mesh100;
        }
        else if (value >= 0.75f)
        {
            MeshFiter.mesh = mesh75;
        }
        else if (value >= 0.50f)
        {
            MeshFiter.mesh = mesh50;
        }
        else if (value >= 0.25f)
        {
            MeshFiter.mesh = mesh25;
        }
    }
}
