using UnityEngine;
using System.Collections;

public class Tipstrigger2 : MonoBehaviour {

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
			"  Last year, this class ______ by Mrs. Agnew.\nA. were taught(turn right)\nB. was taught(turn left)");
		}
	}
}
