using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadSceneWithSpacebar : MonoBehaviour 
{
	public string LevelToLoadName;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			LoadScene();
		}
	}

	void LoadScene()
	{
		SceneManager.LoadScene(LevelToLoadName);
	}
}
