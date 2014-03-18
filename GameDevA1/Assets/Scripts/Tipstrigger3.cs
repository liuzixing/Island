using UnityEngine;
using System.Collections;

public class Tipstrigger3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public GUIText textHints;
	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag == "First Person Controller"){
				textHints.SendMessage("ShowHint",
			"Scott and Mimi ______ to Las Vegas twice.\nA. have gone(turn right)\nB. went (turn left)");
		}
	}
}
