using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingMap : MonoBehaviour {

	public static float speed;

	public int lSpeed;

	// Use this for initialization
	void Start () {
			speed = 10;

		// lSpeed = 5;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward*Time.deltaTime*(speed));
		if(transform.position.z <= -100) {
			Destroy(gameObject);
		}
	}

	public static void SpeedUp() {
		if(speed < 15) {
			speed+=Time.deltaTime;
		}
		else {
			speed = 15;
		}
	}

	public static void DumpSpeed() {
		if(speed > 10) {
			speed-= Time.deltaTime;
		} else {
			speed = 10;
		}
	}

	public static void SpeedDown() {
		if(speed > 0) {
			speed-=Time.deltaTime;
		}
		else {
			speed = 0;
		}
	}
}
