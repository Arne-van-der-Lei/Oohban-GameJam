using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : Singleton<World> {

    Block[,,] block;
    public Vector3 size = new Vector3(5, 5, 5);
    public Vector3 offset = new Vector3(-2.5f, -2.5f, -2.5f);
    public GameObject Air;
    public GameObject canvas;

	// Use this for initialization
	void Start () {
        block = new Block[(int)size.x, (int)size.y, (int)size.z];

        GameObject[] list = GameObject.FindGameObjectsWithTag("Block");

        foreach(GameObject obj in list)
        {
            AddBlock((int)obj.transform.position.x, (int)obj.transform.position.y, (int)obj.transform.position.z, obj);
        }

        for (int i = 0; i < size.x; ++i)
        {
            for (int j = 0; j < size.y; ++j)
            {
                for (int k = 0; k < size.z; ++k)
                {
                    if (block[i, j, k] == null)
                    {
                        GameObject air = Instantiate(Air, new Vector3(i, j, k), Air.transform.rotation);
                        AddBlock(i, j, k, air);
                    }
                }
            }
        }

        canvas = GameObject.Find("Canvas");
        canvas.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddBlock(int x, int y, int z, GameObject bloc)
    {
        if (block[x, y, z] != null) DestroyImmediate(block[x, y, z].gameObject);
        
        block[x, y, z] = bloc.GetComponent<Block>();
    }

    public Block GetBlock(int x, int y, int z)
    {
        if(x >= 0 && y >= 0 && z >= 0)
            return block[x, y, z];  
        return null;
    }

    public void LevelEnd()
    {
        canvas.SetActive(true);
    }
}
