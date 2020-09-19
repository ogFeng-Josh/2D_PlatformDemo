using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public int playerLives = 3;
	public GameObject playerPrefab;
	public Transform respawnLocation;
	public bool playerIsDead;
	CameraFollow camScript;
	public bool hasCheckpoint;
	public GameObject checkpoint;
	public GameObject backgroundMusic;

	public GameObject life1;
	public GameObject life2;
	public GameObject life3;

	public GameObject loseScreen;
	public GameObject winScreen;
	private GameObject player;

	/// SOUNDS
	private AudioSource source;
	public AudioClip gameOverSound;
	public AudioClip gameWinSound;

	// Use this for initialization
	void Start () 
	{
		camScript = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraFollow>();
		source = GetComponent<AudioSource>();
		FindCurrentPlayerObject();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CheckPlayerLives()
	{
		if(playerIsDead)
		{
			playerLives--;//decrement lives by 1
			player = null;
			if(playerLives > 0)
			{
				camScript.enabled = !camScript.enabled;
				RespawnPlayer();
			}
			else
			{
				TriggerGameOver();
			}
			UpdateLives();
		}
	}

	void RespawnPlayer()
	{
		if(hasCheckpoint)
		{
			Instantiate(playerPrefab, checkpoint.transform.position, checkpoint.transform.rotation);
		}
		else if(!hasCheckpoint)
		{
			Instantiate(playerPrefab, respawnLocation.transform.position, respawnLocation.transform.rotation);
		}
		camScript.enabled = enabled;
		camScript.ResetCamera();
		playerIsDead = false;
		//Find new player object
		FindCurrentPlayerObject();
	}

	void TriggerGameOver()
	{
		//Show Lose Screen
		loseScreen.SetActive(true);
		//Turn off background music
		backgroundMusic.SetActive(false);
		//Play losing sound
		source.PlayOneShot(gameOverSound);
	}

	void UpdateLives()
	{
		if(playerLives == 3)
		{
			life1.SetActive(true);
			life2.SetActive(true);
			life3.SetActive(true);
		}
		else if(playerLives == 2)
		{
			life3.SetActive(false);
		}
		else if(playerLives == 1)
		{
			life2.SetActive(false);
		}
		else if(playerLives == 0)
		{
			life1.SetActive(false);
		}
	}

	public void WinLevel()
	{
		//Show Lose Screen
		winScreen.SetActive(true);
		//Turn off background music
		backgroundMusic.SetActive(false);
		//Play losing sound
		source.PlayOneShot(gameWinSound);
		//Turn off character controller...
		FindCurrentPlayerObject();//First make sure we have the correct object...
		player.SetActive(false);

	}

	void FindCurrentPlayerObject()
	{
		//Look through scene and find object tagged as the "Player"
		player = GameObject.FindGameObjectWithTag("Player");
	}
}
