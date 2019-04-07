using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
		
	// Update is called once per frame
	void OnTriggerEnter (Collider boxCollider) {

			if(boxCollider.tag == "Player") {
				Debug.Log("Oops!");
				HealthBar.down(10);
				Destroy(gameObject);
			}
	}
	
}
