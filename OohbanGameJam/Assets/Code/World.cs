using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : Singleton<World> {

    Block[,,] block;
    public Vector3 size = new Vector3(5, 5, 5);
    public Vector3 offset = new Vector3(-2.5f, -2.5f, -2.5f);
    public GameObject[] PrefabList;
    public GameObject canvas;

	// Use this for initialization
	void Start () {
        block = new Block[(int)size.x, (int)size.y, (int)size.z];
        for(int i = 0; i < size.x; ++i)
        {
            for (int j = 0; j < size.y; ++j)
            {
                for (int k = 0; k < size.z; ++k)
                {
                    AddBlock(i, j, k, 0);
                }
            }
        }
        AddBlock(3, 4, 2, 4);
        AddBlock(3, 3, 2, 7);
        AddBlock(2, 3, 2, 7);
        AddBlock(1, 3, 2, 7);
        AddBlock(1, 3, 2, 7);
        AddBlock(0, 3, 2, 10);
        AddBlock(0, 2, 2, 11);
        transform.position = offset;

        canvas = GameObject.FindGameObjectWithTag("Canvas");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddBlock(int x, int y, int z, int id)
    {
        if (block[x, y, z] != null) Destroy(block[x, y, z]);

        GameObject BlockObj = Instantiate(PrefabList[id]) ;
        block[x, y, z] = BlockObj.GetComponent<Block>();
        block[x, y, z].transform.position = new Vector3(x, y, z);
        block[x, y, z].transform.parent = transform;
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
