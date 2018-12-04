using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
	public Animator anim;
	public Rigidbody rbody;

	private float inputH;
	private float inputV;
	private bool run;
	private bool walkback;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		rbody = GetComponent<Rigidbody> ();
		run = false;
		walkback = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown("f")) {
			anim.Play("Picking Up", -1, 0f);
		}

		if (Input.GetKey (KeyCode.LeftShift)) {
			run = true;
		} else {
			run = false;
		}

		if (Input.GetKey (KeyCode.S)) {
			walkback = true;
		} else {
			walkback = false;
		}

		if (Input.GetKey (KeyCode.Space)) {
			anim.SetBool ("jump", true);
		} else {
			anim.SetBool ("jump", false);
		}

		inputH = Input.GetAxis ("Horizontal");
		inputV = Input.GetAxis ("Vertical");

		anim.SetFloat ("inputH", inputH);
		anim.SetFloat ("inputV", inputV);
		anim.SetBool ("run", run);
		anim.SetBool ("walkback", walkback);

		float moveX = inputH * 20f * Time.deltaTime;
		float moveZ = inputV * 50f * Time.deltaTime;

		if (moveZ <= 0f) {
			moveX = 0f;
		} else {
			moveX *= 3f;
			moveZ *= 3f;
		}

		rbody.velocity = new Vector3 (moveX, 0f, moveZ);
	}
}
