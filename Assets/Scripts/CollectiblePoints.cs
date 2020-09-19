using UnityEngine;
using System.Collections;

public class CollectiblePoints : MonoBehaviour {

	/// SOUNDS
	private AudioSource source;
	public AudioClip collectSound;
	private bool isCollected = false;
	private float waitToDestroyTime = 3.0f;
	private Renderer rend;
	public bool hasParticleEffect = false;
	public GameObject particleEffect;
	private LevelManager lm;
	
	// Use this for initialization
	void Start () 
	{
		lm = GameObject.Find("LevelManager").GetComponent<LevelManager>();
		source = GetComponent<AudioSource>();
		rend = GetComponent<Renderer>();
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player" && !isCollected)
		{
			source.PlayOneShot(collectSound);
			isCollected = true;
			rend.enabled = false;
			lm.CupCollected();
			if(hasParticleEffect)
			{
				Destroy(particleEffect);
			}
			StartCoroutine(Delay(waitToDestroyTime));
		}
	}
	
	IEnumerator Delay(float waitTime) 
	{
		yield return new WaitForSeconds(waitTime);
		Destroy(this.gameObject);
	}
}
