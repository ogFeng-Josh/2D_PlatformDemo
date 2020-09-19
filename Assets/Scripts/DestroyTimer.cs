using UnityEngine;
using System.Collections;

public class DestroyTimer : MonoBehaviour 
{
	public float waitTime = 5.0f;

	// Use this for initialization
	void Start () 
	{
		StartCoroutine(Delay(waitTime));
	}

	IEnumerator Delay(float waitTime) 
	{
		yield return new WaitForSeconds(waitTime);
		DestroyObject();
	}

	void DestroyObject()
	{
		Destroy(this.gameObject);
	}
}
