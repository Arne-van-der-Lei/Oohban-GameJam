using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : Singleton<World> {

    GameObject[,,] block;
    public Vector3 size = new Vector3(5, 5, 5);
    public Vector3 offset = new Vector3(1, 1, 1);
    public GameObject[] PrefabList;

	// Use this for initialization
	void Start () {
        block = new GameObject[(int)size.x, (int)size.y, (int)size.z];
		for(int i = 0; i < size.x; i++)
        {
            for(int j = 0; j < size.y; j++)
            {
                for (int k = 0; k < size.z; k++)
                {
                    block[i, j, k] = Instantiate(PrefabList[0], new Vector3(offset.x * i, offset.y * j, offset.z * k), Quaternion.identity);
                    block[i, j, k].transform.parent = transform;
                }
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
