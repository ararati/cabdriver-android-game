using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour {
	private float xRotation;
	private float yRotation;
	// Use this for initialization
	void Start () {
		xRotation = 190;
		yRotation = -50;
	}
	
	// Update is called once per frame
	void Update () {
		// if(xRotation > 260) {
			// xRotation = -150;
		// }
		// xRotation += Time.fixedDeltaTime*20;
		// transform.rotation = Quaternion.Euler(xRotation, -50f, 0.0f);
		// new Quaternion(3, Mathf.Sin(Time.fixedTime*15)/80, Mathf.Sin(Time.fixedTime*15)/80, Mathf.Sin(Time.fixedTime*15)/80);
		// transform.rotation = new Quaternion(transform.rotation.x,Mathf.Sin(Time.fixedTime*15)*20,transform.rotation.y,transform.rotation.z);
		// transform.position = new Vector3(transform.position.x, 0.15f + Mathf.Sin(Time.fixedTime*15)*80, transform.position.z);
		// gameObject.transform.rotation = new Vector3(transform.position.x, transform.position.y, transform.position.z);
		// gameObject.transform.rotation = transform.rotation.w;
	}

	public void SliderChanged(float val) {
		// transform.rotation = Quaternion.Euler(val, -50f, 0.0f);
	}
}
