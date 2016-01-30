using UnityEngine;
using System.Collections;

public class SpawnController : MonoBehaviour {

	public ParticleSystem enemySpawner;
	public float time;
	// Use this for initialization
	void Start () {
		Lv1 ();
		for(int i=0; i<StaticParameter.stageLv;i++){
			LvUp();
		}
	}

	void Lv1(){
		enemySpawner.emissionRate = 0.2f;
		enemySpawner.startSpeed = -0.5f;
	}

	public void LvUp(){
		float stats = Random.Range(0,2);
		//Debug.Log(stats);
		if(stats<0.5f){
			enemySpawner.emissionRate = enemySpawner.emissionRate*2;
		}else{
			enemySpawner.startSpeed = enemySpawner.startSpeed*2;
		}
	}
	public void Stop(){
		enemySpawner.enableEmission=false;
	}
}
