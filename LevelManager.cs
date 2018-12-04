using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager: MonoBehaviour {

	public void OnStartGame(string Scenename)
	{
		Application.LoadLevel (Scenename);
	}
	public void OnExitGame()
	{
		Application.Quit();
	}

}
