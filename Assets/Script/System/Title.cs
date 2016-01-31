using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Title : MonoBehaviour {

	public GameObject tutorialPopUp;
	public GameObject continuePopUp;
	public GameObject intro;

	public Text lastScores;
	public Text highScores;

	public Text startLevel;

	public int startLevelInt;

	public void Start(){
		startLevelInt = 0;
		StaticParameter.lastScore =0;
		lastScores.text = lastScores.text + StaticParameter.lastScore.ToString();
		highScores.text = highScores.text + StaticParameter.highScore.ToString();
	}
	public void ShowIntro(){
		intro.SetActive(true);
	}
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
	public void HideContinue(){
		continuePopUp.SetActive(false);
	}
	public void IncLevel(){
		startLevelInt++;
		startLevel.text = startLevelInt.ToString();
	}
	public void DecLevel(){
		if(startLevelInt>0){
			startLevelInt--;
			startLevel.text = startLevelInt.ToString();
		}
	}
	public void Continue(){
		StaticParameter.stageLv = int.Parse(startLevel.text);
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
