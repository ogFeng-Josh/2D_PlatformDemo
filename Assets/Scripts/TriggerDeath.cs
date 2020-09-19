using UnityEngine;
using System.Collections;

public class TriggerDeath : MonoBehaviour 
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

	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.tag == "Player")
		{
			gm.playerIsDead = true;
			Destroy(col.gameObject);
			gm.CheckPlayerLives();
		}
	}
}
