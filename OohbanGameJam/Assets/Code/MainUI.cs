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
		if(SceneManager.GetActiveScene().name == "MainMenuUI")
        { 
		    if(Input.anyKey)
		    {
			    SceneManager.LoadScene("levelSelectorUI");
		    }
        }
    }

    public void CickStart()
    {
        SceneManager.LoadScene("levelSelectorUI");
    }
    public void SelectLevel1()
    {
    	SceneManager.LoadScene("Level1");
    }
    public void SelectLevel2()
    {
    	SceneManager.LoadScene("Level2");
    }
    public void SelectLevel3()
    {
    	SceneManager.LoadScene("Level 3");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
