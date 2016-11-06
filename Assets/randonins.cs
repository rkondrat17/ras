using UnityEngine;
using System.Collections;

public class randonins : MonoBehaviour {

	public float secondsSpawn = 5.0f; 
	public GameObject fallingCube; 

	//private variables 

	private Vector3 higherUpPosition; 
	private Vector3 offset; 
	private bool fallingSpawned = false; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (!fallingSpawned) { 
			StartCorountine (SpawnedFallingCubeEveryXSeconds (secondsSpawned));
	
		}
	}

		IEnumerator SpawnedFallingCubeEveryXSeconds (float seconds)
	{
		fallingSpawned = true;
		offset = new Vector3 (Random.Range (-20.0f, 20.0f), 50.0f, Random.Range (-20.0f, 20.0f));
		higherUpPosition = Vector3.up * Random.Range (20.0f, 150.0f) + offset; 
		Instantiate (fallingCube, higherUpPosition, Quaternion.identity); 
		yield return new WaitForSeconds (seconds); 
		fallingSpawned = false; 

	}
}
