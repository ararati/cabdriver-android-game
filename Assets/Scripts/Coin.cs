using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour {

	public Text coinsCount;
	// Use this for initialization
	void Start () {
		coinsCount = GameObject.Find("CoinsCount").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider coinCollider) {
			if(coinCollider.name == "Player") {
				coinsCount.text = (int.Parse(coinsCount.text)+1).ToString();
				Destroy(gameObject);
			
			}
	}
}
