using UnityEngine;
using System.Collections;

public class ThrowTrigger : MonoBehaviour {
	public GUITexture crosshair;
	public GUIText textHints;
	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag == "First Person Controller"){
			if(!CoconutWin.haveWon){
				textHints.SendMessage("ShowHint","\n\n\n\n\n There's a power cell attached to this game, \nmaybe I'll win it if I can knock down all the targets...");
			}
			crosshair.enabled=true;
			CoconutThrower.canThrow=true;
		}
	}
	void OnTriggerExit(Collider col){
		if(col.gameObject.tag == "First Person Controller"){
			CoconutThrower.canThrow=false;
			crosshair.enabled=false;
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
