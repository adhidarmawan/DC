using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class PopScores : MonoBehaviour {

	public List<Text> popScoresPassive;
	public List<Text> popScoresActive;

	public void PopUpScores(int enemyType){
		if(popScoresPassive.Count>0){
			if(enemyType>0){
				popScoresPassive[0].text = "+"+(enemyType*100).ToString();
			}else{
				popScoresPassive[0].text = (enemyType*100).ToString();
			}
			Debug.Log(popScoresPassive[0].text);
			popScoresActive.Add(popScoresPassive[0]);
			popScoresPassive[0].gameObject.SetActive(true);
			popScoresPassive.RemoveAt(0);
		}
	}
	public void HideScore(){
		if(popScoresActive.Count>0){
			popScoresPassive.Add(popScoresActive[0]);
			popScoresActive[0].gameObject.SetActive(false);
			popScoresActive.RemoveAt(0);
		}
	}
	public void Delete(){
		Destroy(this.gameObject);
	}
}
