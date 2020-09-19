using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour 
{
	public float waitTime = 5.0f;
	public bool endlessSpawning = false;
	public GameObject objectToSpawn;
	
	// Use this for initialization
	void Start () 
	{
		StartCoroutine(Delay(waitTime));
	}
	
	IEnumerator Delay(float waitTime) 
	{
		yield return new WaitForSeconds(waitTime);
		InstantiateObject();
	}
	
	void InstantiateObject()
	{
		Instantiate(objectToSpawn, objectToSpawn.transform.position, objectToSpawn.transform.rotation);
		if(endlessSpawning)
		{
			StartCoroutine(Delay(waitTime));
		}
	}
}
