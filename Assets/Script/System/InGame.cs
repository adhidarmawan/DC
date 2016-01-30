using UnityEngine;
using System.Collections;

public class InGame : MonoBehaviour {

	public void NextDay(){
		StaticParameter.stageLv++;
		Application.LoadLevel("DetectEnemy");
	}
	public void Title(){
		StaticParameter.stageLv++;
		Application.LoadLevel("TitleScreen");
	}
	public void CheckStage(){
		if(StaticParameter.baseLv<StaticParameter.stageLv){
			StaticParameter.baseLv = StaticParameter.stageLv+1;
		}
	}
}
