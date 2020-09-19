using UnityEngine;
using System.Collections;

public class CloudMovement : MonoBehaviour 
{
	public float moveSpeed = 0.5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(Vector3.left * (Time.deltaTime * moveSpeed));
	}
}
