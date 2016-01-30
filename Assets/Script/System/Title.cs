using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour {

	public GameObject tutorialPopUp;
	public GameObject continuePopUp;

	public void PlayGame(){
		StaticParameter.stageLv =0;
		Application.LoadLevel("DetectEnemy");
	}
	public void LookHighScore(){
		Application.LoadLevel("DetectEnemy");
	}
	public void PopContinue(){
		continuePopUp.SetActive(true);
	}
	public void Continue(){
		Application.LoadLevel("DetectEnemy");
	}
	public void PopTutorial(){
		tutorialPopUp.SetActive(true);
	}
	public void CloseTutorial(){
		tutorialPopUp.SetActive(false);
	}
	public void ExitGame(){
		Application.Quit();
	}
}
