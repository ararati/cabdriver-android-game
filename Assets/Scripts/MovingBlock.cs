using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlock : MonoBehaviour {

	public static float speed;

	private static float forwardSpeed = 20f;

	private static float backwardSpeed = 0f;

	private bool isForward;

	// Use this for initialization
	void Start () {	
		
	}

	public void setForward(bool isForward) {
		this.isForward = isForward;
		// if(isForward)
		// 	speed = forwardSpeed;
		// else
		// 	speed = backwardSpeed;
	}
	
	// Update is called once per frame
	void Update () {	
		Vector3 vec;
		if(isForward)
			vec = Vector3.left;
		else
			vec = Vector3.right;

		transform.Translate(vec*Time.deltaTime*(getSpeed()));
		if(transform.position.z <= -65) {
			Destroy(gameObject);
		}
	}

	public float getSpeed() {
		if(isForward)
			return forwardSpeed;
		else
			return backwardSpeed;
	}

	public static void SpeedUp() {
		if(forwardSpeed < 25) {
			forwardSpeed+= Time.deltaTime;
		}

		if(backwardSpeed < 7) {
			backwardSpeed+= Time.deltaTime;
		}
	}

	public static void DumpSpeed() {
		if(forwardSpeed > 13) {
			forwardSpeed-= Time.deltaTime;
		}

		if(backwardSpeed > 0) {
			backwardSpeed-= Time.deltaTime;
		} else
			backwardSpeed = 0;
	}
}
