using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Tutorial : MonoBehaviour {

	public Image tutorialPage;
	public List<Sprite> tutorialImg;
	public int tutorialNum;

	public void Start(){
		tutorialNum = 0;
	}

	public void ShowTutorial(){
		tutorialPage.gameObject.SetActive(true);
	}
	public void HideTutorial(){
		tutorialNum = 0;
		tutorialPage.sprite = tutorialImg[tutorialNum];
		tutorialPage.gameObject.SetActive(false);
	}
	public void NextTutorial(){
		if(tutorialNum<tutorialImg.Count-1){
			tutorialNum++;
		}else{
			tutorialNum =0;
		}
		tutorialPage.sprite = tutorialImg[tutorialNum];
	}

}
