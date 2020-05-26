using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
	public GameObject moleContainer;
	public TextMesh infoText;
	public Player player;
	public float spawnDuration = 1.5f;
	public float spawnDecrement = 0.1f;
	public float minimumSpawnDuration = 0.5f;
	public float gameTimer = 15f;
	private Mole[] moles;
	private float spawnTimer = 0f;
    // Start is called before the first frame update
    void Start()
    {
		moles = moleContainer.GetComponentsInChildren<Mole> ();

		moles [Random.Range (0, moles.Length)].Rise ();
	}

    // Update is called once per frame
    void Update()
    {
		spawnTimer -= Time.deltaTime;
		if (spawnTimer <= 0f) {
			moles [Random.Range (0, moles.Length)].Rise ();

			spawnDuration -= spawnDecrement;
			if (spawnDuration < minimumSpawnDuration) {
				spawnDuration = minimumSpawnDuration;
			}
		}
		gameTimer -= Time.deltaTime;
		if (gameTimer > 0f) {
			infoText.text = "Hit all the moles!\nTime: " + Mathf.Floor (gameTimer) + "\nScore: " + player.score;
			spawnTimer -= Time.deltaTime;
			if (spawnTimer <= 0f) {
				moles [Random.Range (0, moles.Length)].Rise ();

				spawnDuration -= spawnDecrement;
				if (spawnDuration < minimumSpawnDuration) {
					spawnDuration = minimumSpawnDuration;
				}
			
			else{
					infoText.text = "Game over! Your score: " + Mathf.Floor (player.score);
				}
			}
		}
	}
}