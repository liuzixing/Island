using UnityEngine;
using System.Collections;

public class Tipstrigger1 : MonoBehaviour {
	public GUIText textHints;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag == "First Person Controller"){
				textHints.SendMessage("ShowHint",
			" I ______ him an email message last week.\nA. sent(turn right)\nB. had sent(turn left)");
		}
	}
}
