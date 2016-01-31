using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Props : MonoBehaviour {

	public List<GameObject> propSets;

	// Use this for initialization
	void Start () {
		for(int i =0; i<StaticParameter.stageLv;i++){
			int props = Random.Range(0,propSets.Count+1);
			propSets[props].SetActive(true);
		}

	}

}
