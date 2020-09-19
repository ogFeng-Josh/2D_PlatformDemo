using UnityEngine;
using System.Collections;

public class WinTrigger : MonoBehaviour 
{
	GameManager gm;

	// Use this for initialization
	void Start () 
	{
		gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			gm.WinLevel();
		}
	}
}
