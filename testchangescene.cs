using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class testchangescene : MonoBehaviour {
	GameManager gameManager;
	void Awake()
	{
		gameManager = FindObjectOfType<GameManager>();
	}
	void OnCollisionEnter()
	{
		//gameManager.testmoney += 10;
		//Debug.Log("金錢="+gameManager.testmoney);
		Application.LoadLevel ("mapN");
	}
}
