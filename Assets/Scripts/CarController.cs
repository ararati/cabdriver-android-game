using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

	public Transform target;

	public Vector3 moveLeftVector;
	public Vector3 moveRightVector;

	public float speed;

	public bool isRight;
	public bool isLeft;
	public bool isGas;

	public bool isBreak;

	public Camera cam;

	SteeringWheel steeringWheel;

	// Use this for initialization
	void Start () {
		steeringWheel = GetComponent<SteeringWheel>();
		cam = cam.GetComponent<Camera>();
	}
	

	// Update is called once per frame
	void Update () {	
		// Debug.Log("Speed: " + speed);
		// Debug.Log("Sin: " +  Mathf.Sin(Time.fixedTime)/10 + "Time: " + Time.fixedTime);
		transform.position = new Vector3(transform.position.x, 0.15f + Mathf.Sin(Time.fixedTime*15)/80, transform.position.z);

		turnCar();
		// Debug.Log(steeringWheel.GetAngle());
		//Vector3 movePos = new Vector3(target.position.x, target.position.y, target.position.z);
		// Vector3 movePos = new Vector3(target.position.x, 0.18f, -5.71f);

		 
		// if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) 
		// {
		// 	turnLeft();
		// }

		// if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) 
		// {
		// 	turnRight();
		// }

		if(Input.GetKey(KeyCode.W)) 
		{
			turnGas();
		} else if(!isBreak) {
			DumpSpeed();
		}

		// if(Input.GetKey(KeyCode.S)) 
		// {
		// 	turnBreak();
		// }
		
		// if(isGas) 
		// {
		// 	turnGas();
		// } else {
		// 	if(!isBreak)
		// 		DumpSpeed();
		// }

		// if(isBreak) {
		// 	turnBreak();
		// }

		// if(isRight) 
		// {
		// 	turnRight();
		// }

		// if(isLeft) 
		// {
		// 	turnLeft();
		// }
		


		// transform.LookAt(target);
		// transform.position = Vector3.MoveTowards(transform.position, movePos, Time.deltaTime*(speed-0.5f));
	}

	public void turnGas(){
		
		isBreak = false;
		MovingMap.SpeedUp();
		MovingBlock.SpeedUp();

		if(cam.fieldOfView < 67) {
			cam.fieldOfView += Time.deltaTime*2;
			speed+=Time.deltaTime*2;
		} else {
			speed = 5;
		}
	}

	public void turnBreak() {
		isBreak = true;
		MovingMap.SpeedDown();
	}

	public void DumpSpeed() {
		MovingMap.DumpSpeed();
		MovingBlock.DumpSpeed();
		if(cam.fieldOfView > 62) {
			cam.fieldOfView -= Time.deltaTime*2;
			speed-=Time.deltaTime*2;
		} 
	}
	public void turnCar() {
		// transform.Rotate(Vector3.right * Time.deltaTime);
		float angle;
		if(transform.position.x > -2.5f && transform.position.x < 1.34f) {
			angle = steeringWheel.GetClampedValue();
		} else if(transform.position.x < -2.5f){
			angle = Time.deltaTime/2;
		} else {
			angle = -Time.deltaTime/2;
		}
		
		// if(transform.position.x < 2.5f) {
		// 	angle = steeringWheel.GetClampedValue();
		// } else {
		// 	angle = -Time.deltaTime/2;
		// }
		
		transform.Translate(new Vector3(angle, 0, 0) * Time.deltaTime * 4);
		// else 
			// transform.position = new Vector3(-2.5f, 0, 0);
		// transform.Rotate(0, steeringWheel.GetClampedValue(), 0);
	}

	// public void turnLeft() {
	// 		if(target.transform.position.x > -2.7f) 
	// 		{
	// 			target.transform.Translate(moveLeftVector * Time.deltaTime * speed);
	// 		} else {
	// 			target.transform.position = new Vector3(-2.7f, target.position.y, target.position.z);
	// 		}
	// }

	// public void turnRight() {
	// 	if(target.transform.position.x < 1.2f) 
	// 	{
	// 		target.transform.Translate(moveRightVector * Time.deltaTime * speed);
	// 	}
	// }

	public void setRight(bool isOn) {
		isRight = isOn;
	}

	public void setLeft(bool isOn) {
		isLeft = isOn;
	}

	public void setGas(bool isOn) {
		isGas = isOn;
	}
}
