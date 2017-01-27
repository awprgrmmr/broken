using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//TODO: public class ControllerZ : MonoBehaviour {
public class Controller : MonoBehaviour {

	public Canvas GameMenu;
	public Button StartB;
	public Button QuitB;

	// Use this for initialization
	void Start () {
		GameMenu = GameMenu.GetComponent<Canvas> ();
		StartB = StartB.GetComponent<Button> ();
		QuitB = QuitB.GetComponent<Button> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Quit()
	{
		Debug.Log ("Quit button pressed");
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#elif UNITY_WEBPLAYER
		Application.OpenURL(webplayerQuitURL);
		#else
		Application.Quit();
		#endif
	}

	public void StartLevel(){
		Debug.Log ("Start Pressed");
	}
}
