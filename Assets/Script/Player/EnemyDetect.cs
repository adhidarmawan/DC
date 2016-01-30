using UnityEngine;
using System.Collections;

public class EnemyDetect : MonoBehaviour {

	public bool isSpawn;

	// Use this for initialization
	void Start () {
		isSpawn =false;
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	void OnParticleCollision(GameObject particle){
		//DestroyObject(particle);
		isSpawn = true;
		//Debug.Log("particle");
	}
}
