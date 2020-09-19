using UnityEngine;
using System.Collections;

public class FlashObject : MonoBehaviour 
{
	public float waitTime = 1f;
	private bool isOn = false;
	public GameObject ObjectToToggle;

	// Use this for initialization
	void Start () 
	{
		StartCoroutine(Delay(waitTime));//Run delay
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	IEnumerator Delay(float waitTime) 
	{
		yield return new WaitForSeconds(waitTime);
		ToggleObject();
	}

	void ToggleObject()
	{
		if(isOn)//If the object is on turn it off...
		{
			ObjectToToggle.SetActive(false);
			isOn = false;
		}
		else if(!isOn)//Else if the object is off turn it on...
		{
			ObjectToToggle.SetActive(true);
			isOn = true;
		}
		StartCoroutine(Delay(waitTime));//Run delay
	}
}
