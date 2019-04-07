using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCamera : MonoBehaviour {

	public Transform target; // Указываем обьект контроля.

	public bool smoothRotation; // Преключатель Включаем - Выключаем плавное слежение.

	public float rotationDamping = 10.0f; // 
	
	private Vector3 pos;
	// Use this for initialization
	void Start () {
		pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		// transform.position = new Vector3(transform.position.x, pos.y, transform.position.z);
		// Vector3 movePos = new Vector3(target.transform.position.x, transform.position.y, transform.position.z);
		// transform.position = Vector3.MoveTowards(transform.position, movePos, Time.deltaTime*(4-0.5f));
		// if(transform.position!= new Vector3(50, 0, 0)) {
		// transform.position = new Vector3(Mathf.Lerp(0, 50, 5*Time.deltaTime), 0, 0);
		// if (smoothRotation) {
		// 	var wantedRotation = Quaternion.LookRotation(target.position - transform.position, target.up);

		// 			transform.rotation = Quaternion.Slerp (transform.rotation, wantedRotation, Time.deltaTime * rotationDamping);
		// 	}
		// 		else transform.LookAt (target, target.up);
		// }
	}
	
}
