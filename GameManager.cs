using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public static GameManager instance;
	//public int testmoney=0;

	void Awake () 
	{
		if (instance == null) 
		{
			instance = this;
		}
		else if (instance != this)
		{
			Destroy (gameObject);
		}
		DontDestroyOnLoad (gameObject);


	}

	/*void Awake() 
	{
		if (instance == null) 
		{
			instance = this;
		}
		else if (instance != this)
		{
			Destroy (gameObject);
		}
	    DontDestroyOnLoad (gameObject);
	}
	*/
	/*	
	public void gotogreenstage()
	{
	    SceneManager.LoadScene ("greenstage");
	}
	public void gotobluestage()
	{
		SceneManager.LoadScene ("bluestage");
	}
	public void gotowhitestage()
	{
		SceneManager.LoadScene ("whitestage");
	}
	public void gotoredstage()
	{
		SceneManager.LoadScene ("redstage");
	}
	public void gotomovietheater()
	{
		SceneManager.LoadScene ("movietheater");
	}
	public void gotomenustage()
	{
		SceneManager.LoadScene ("menu");
	}
	public void RestartByBug()
	{
		SceneManager.LoadScene ("menu");
	}
*/

} 
