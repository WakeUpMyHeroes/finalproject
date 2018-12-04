using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour {
	public Transform[] SpawnPoints;//Create an array of a coordinate
	public float spawnTime = 5f;//How long does it create
	public GameObject[] Items;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawnItems",spawnTime,spawnTime);//Constantly call this method
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SpawnItems(){
		int spawnIndex = Random.Range(0,SpawnPoints.Length);
		int ItemIndex = Random.Range (0, Items.Length);
		Instantiate (Items[ItemIndex], SpawnPoints [spawnIndex].position,SpawnPoints[spawnIndex].rotation);
	}
}
