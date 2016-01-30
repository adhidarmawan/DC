using UnityEngine;
using System.Collections;

public class SpawnController : MonoBehaviour {

	public ParticleSystem enemySpawner;
	public float time;
	// Use this for initialization
	void Start () {
		Lv1 ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}

	void Lv1(){
		enemySpawner.emissionRate = 0.2f;
		enemySpawner.startSpeed = -0.5f;
	}

	public void LvUp(){
		enemySpawner.emissionRate = enemySpawner.emissionRate*2;
		enemySpawner.startSpeed = enemySpawner.startSpeed*2;
	}
	public void Stop(){
		enemySpawner.enableEmission=false;
	}
}
