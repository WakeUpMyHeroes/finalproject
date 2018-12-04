using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
	public float RotateSpeed = 50f; //define the tool Rotate Speed
	public float DestroyTime = 10f;//define the tool Destroy Time


	// Use this for initialization
	void Start () {
		Destroy (gameObject, DestroyTime);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up * Time.deltaTime * RotateSpeed, Space.World);
	}
}
