using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapSpawner : MonoBehaviour {

	public GameObject[] SpawnObjects;

	private GameObject lastMap;

	// Use this for initialization
	void Start () {
		SpawnMap();
	}

	void Update() {
		if(lastMap.transform.position.z <= 1) {
			SpawnMap();
		}

		// Debug.Log("Last map: " + lastMap.transform.position.z + " Map spawner Z: " + transform.position.z);
	}

	private void SpawnMap() {
		lastMap = Instantiate(SpawnObjects[Random.Range(0, SpawnObjects.Length)], transform.position, transform.rotation) as GameObject;
	}
		
	// Update is called once per frame
	void OnTriggerEnter (Collider boxCollider) {
			// if(boxCollider.name == "Player") {
			// 	SceneManager.LoadScene("Crash");
			// }
	}
	
}
