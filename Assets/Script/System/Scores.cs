using UnityEngine;
using System.Collections;

public class Scores : MonoBehaviour {

	public PopScores parent;

	public void Disconnect(){
		parent.HideScore();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
