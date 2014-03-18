using UnityEngine;
using System.Collections;
[RequireComponent (typeof (AudioSource))]

public class MainMenuGUI : MonoBehaviour {
	public AudioClip beep;
	public GUISkin menuSkin;
	public Rect menuArea;
	public Rect playButton;
	public Rect instructionsButton;
	public Rect quitButton;
	Rect menuAreaNormalized;
	string menuPage = "main";
	public Rect instructions;
	public Rect teammessage;
	void Start(){
		menuAreaNormalized =
			new Rect(menuArea.x * Screen.width - (menuArea.width * 0.5f),
			menuArea.y * Screen.height - (menuArea.height * 0.5f),
			menuArea.width, menuArea.height);
	}
	IEnumerator ButtonAction(string levelName){
		audio.PlayOneShot(beep);
		yield return new WaitForSeconds(0.35f);
		if(levelName != "quit"){
			Application.LoadLevel(levelName);
		}else{
			Application.Quit();
			Debug.Log("Have Quit");
		}
	}
	void OnGUI(){
		GUI.skin = menuSkin;
		GUI.BeginGroup (menuAreaNormalized);
		GUI.Label(new Rect(teammessage),"team 4");
		if(menuPage == "main"){
			if(Application.CanStreamedLevelBeLoaded("Island")){
				if(GUI.Button(new Rect(playButton), "Play")){
					StartCoroutine("ButtonAction", "ISLAND");
				}
			}else{
				float percentLoaded =
				Application.GetStreamProgressForLevel(1) * 100;
				GUI.Box(new Rect(playButton),
				"Loading.. " + percentLoaded.ToString("f0") + "% Loaded");
			}
			if(GUI.Button(new Rect(instructionsButton), "Instructions")){
				audio.PlayOneShot(beep);
				menuPage="instructions";
			}
			if(Application.platform != RuntimePlatform.OSXWebPlayer
				&& Application.platform != RuntimePlatform.WindowsWebPlayer){
				if(GUI.Button(new Rect(quitButton), "Quit")){
					StartCoroutine("ButtonAction", "quit");
				}
			}
		}else if(menuPage == "instructions"){
			GUI.Label(new Rect(instructions),
			"You awake on a mysterious island...Find a way to signal for help or face certain doom!");
			if(GUI.Button(new Rect(quitButton), "Back")){
				audio.PlayOneShot(beep);
				menuPage="main";
			}
		}
		GUI.EndGroup();
	}

}
