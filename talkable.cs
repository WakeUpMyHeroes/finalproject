using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
//using UnityEditor;

public class talkable : MonoBehaviour
{
    public static Flowchart flowchartManager;
    public static Flowchart talkFlowchart;
	public string onCollisionEnter;
	public string onMouseDown="NPC A";
	//Rigidbody playerRigidbody;
	void Awake()
	{
		flowchartManager = GameObject.Find ("對話管理器").GetComponent<Flowchart> ();
		talkFlowchart = GameObject.Find ("人物對話").GetComponent<Flowchart> ();
		//playerRigidbody = FindObjectOfType<UnityChanControlScriptWithRgidBody> ().GetComponent<Rigidbody> ();
	}

    void Update()
    {

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
			//Selection.activeGameObject = talkFlowchart.gameObject;
		}
	}
    //Fungus 3.7版以後也內建了一個Collision，為了避免跟Unity內建的Collision混淆,這邊需要特別指明是Unity本身的Collision
    private void OnCollisionEnter(UnityEngine.Collision other)
    {
		
		if (!string.IsNullOrEmpty (onCollisionEnter)&&!isTalking) {
			
			if (other.gameObject.CompareTag ("player")) {
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