using UnityEngine;
using System.Collections;

public class CheckpointTrigger : MonoBehaviour 
{
	GameManager gm;
	public GameObject inactive;
	public GameObject active;
	private bool hasCheckpoint = false;
	/// SOUNDS
	private AudioSource source;
	public AudioClip checkPointSound;
	
	// Use this for initialization
	void Start () 
	{
		source = GetComponent<AudioSource>();
		gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
	}
		
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player" && !hasCheckpoint)
		{
			gm.hasCheckpoint = true;
			inactive.SetActive(false);
			active.SetActive(true);
			source.PlayOneShot(checkPointSound);
			hasCheckpoint = true;
		}
	}
}
