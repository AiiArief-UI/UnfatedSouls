using UnityEngine;
using System.Collections;

public class MainMenuUIManager : MonoBehaviour {

	public GameObject mainMenu, settingPanel, memoryPanel;

	void Start () {
	}

	// Update is called once per frame
	void Update () {
	}

	public void OpenSetting(){
		mainMenu.SetActive (false);
		settingPanel.SetActive (true);
	}

	public void OpenMemory(){
		mainMenu.SetActive (false);
		memoryPanel.SetActive (true);
	}


	public void Back(){
		settingPanel.SetActive (false);
		memoryPanel.SetActive (false);
		mainMenu.SetActive (true);
	}

	public void LoadLevel(string level){
		Application.LoadLevel(level);
	}

	public void Quit(){
		Debug.Log ("Game QUIT");
		Application.Quit();
	}
}
