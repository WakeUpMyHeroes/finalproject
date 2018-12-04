using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;

public class AIController: MonoBehaviour {
	GameObject[] goalLocations;
	NavMeshAgent agent;
	Animator anim;

	void Start () {
		goalLocations = GameObject.FindGameObjectsWithTag("goal");
		agent = GetComponent<NavMeshAgent>();
		agent.destination = goalLocations[Random.Range(0,goalLocations.Length)].transform.position;

		anim = GetComponent<Animator> ();
		anim.SetTrigger ("isWalking");

		anim.SetFloat ("wOffset", Random.Range(0,1));
		float sm = Random.Range (0.1f, 1.5f);
		anim.SetFloat ("speedMult", sm);
		agent.speed += sm;
	}

	void Update () {
		if(agent.remainingDistance < 1) {
			agent.destination = goalLocations[Random.Range(0,goalLocations.Length)].transform.position;
		}
	}
}