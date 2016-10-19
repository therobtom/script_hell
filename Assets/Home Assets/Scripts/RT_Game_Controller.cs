using UnityEngine;
using System.Collections;

public class RT_Game_Controller : MonoBehaviour
{
	public GameObject hazard;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	private float timeSince = 0;
	private bool isSpawning = false;

	void Start ()
	{
		StartCoroutine (SpawnWaves ());
	}

	void Update (){

		timeSince += Time.deltaTime;
		if (timeSince >= 5) {
			Debug.Log ("update");

			timeSince = 0;
			StartCoroutine (SpawnWaves ());
		}

	}


	IEnumerator SpawnWaves ()
	{
		Debug.Log("WAVE");
		yield return new WaitForSeconds (startWait);

			for (int i = 0; i < hazardCount; i++)
			{
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
				Debug.Log (" Spawned one");

			}

			yield return new WaitForSeconds (waveWait);



	}
}