using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlock : MonoBehaviour {

	public GameObject SpawnObject;

	public GameObject[] SpawnObjects;
	public bool isRandomObjects;
	public float spawnDelay;

	public bool isSameDelay;
	public bool isRandomDelay;
	public bool distanceBorn;
	public bool forwardRoad;

	public float minDelay;
	public float maxDelay;

	public float waitTime = 0;

	private Vector3 positionBorn;

	private GameObject lastBornObj;
	
	private int randomDistance;
	
	// Use this for initialization
	void Start () 
	{
		spawnBlock();
		if(isSameDelay) 
		{
			InvokeRepeating("spawnBlock", waitTime, spawnDelay);
		}

		if(isRandomDelay)
		{
			StartCoroutine(Spawner());
		}
	}

	void Update() {
		if(distanceBorn == true && lastBornObj.transform.position.z <= randomDistance) 
		{
			randomDistance = Random.Range(10, 50);
			Debug.Log("Distance born:" + lastBornObj.transform.position.z);
			spawnBlock();
		}
	}

	IEnumerator Spawner() 
	{
		yield return new WaitForSeconds(Random.Range(minDelay, maxDelay));
		spawnBlock();
	}
	
	// Update is called once per frame
	void spawnBlock() 
	{
		if(!isRandomObjects) {
			GameObject block = Instantiate(SpawnObject, transform.position, transform.rotation) as GameObject;
			lastBornObj = block;
		} 
		else {

			GameObject spawnObj = SpawnObjects[Random.Range(0, SpawnObjects.Length)];

			Vector3 movePos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
			
			GameObject block2 = Instantiate(spawnObj, movePos, transform.rotation) as GameObject;
			lastBornObj = block2;
			block2.AddComponent<EnemyCollision>();
			block2.AddComponent<MovingBlock>();
			// block2.transform.rotation = Quaternion.LookRotation(Vector3.zero);
			if(forwardRoad) {
				block2.GetComponent<MovingBlock>().setForward(true);
			} else {
				block2.GetComponent<MovingBlock>().setForward(false);
			}
		}

		// if(!isSameDelay) {
		// 	StartCoroutine(Spawner());
		// }
	}
}
