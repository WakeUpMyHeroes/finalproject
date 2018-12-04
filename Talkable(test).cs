using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEditor;

public class TalkableTest : MonoBehaviour {
	public static Flowchart flowchartManager;
	public Flowchart talkFlowchart;
	public string onCollisionEnter;
	public string onMouseDown="滑鼠點擊";
	//public string onMouseEnter="滑鼠進入";
	Rigidbody playerRigidbody;
	void Awake()
	{
		flowchartManager = GameObject.Find ("對話管理器").GetComponent<Flowchart> ();
		playerRigidbody = FindObjectOfType<Player> ().GetComponent<Rigidbody> ();
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public static bool isTalking
	{
		get {return flowchartManager.GetBooleanVariable ("對話中"); }
	}
	void PlayBlock(string targetBlockName)
	{
		Block targetBlock = talkFlowchart.FindBlock (targetBlockName);
		if (targetBlock != null) {
			talkFlowchart.ExecuteBlock (targetBlock);
		} else {
			Debug.LogError ("找不到在" + talkFlowchart.name + "裡的" + targetBlockName + "Block");
			Selection.activeGameObject = talkFlowchart.gameObject;
		}
	}
	private void OnCollisionEnter(UnityEngine.Collision other)
	{
		if (!string.IsNullOrEmpty (onCollisionEnter)&&!isTalking) {
			if (other.gameObject.CompareTag ("player")) {
				playerRigidbody.Sleep ();
				PlayBlock(onCollisionEnter);
			}	
		}
	}
	private void OnMouseDown()
	{
		if (!string.IsNullOrEmpty (onMouseDown) && !isTalking) {
			PlayBlock (onMouseDown);
		}
	}

}
