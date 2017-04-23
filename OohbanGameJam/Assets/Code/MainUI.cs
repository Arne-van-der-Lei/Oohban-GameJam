using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.anyKey)
		{
			SceneManager.LoadScene("MainScene");
		}
	}

    public void CickStart()
    {
        SceneManager.LoadScene("MainScene");
    }
}
