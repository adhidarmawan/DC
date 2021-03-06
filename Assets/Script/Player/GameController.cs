﻿using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public bool isGameOver;
	public Watch watch;
	public SpawnController enemies;
	public int lvUp;
	public int lvUpBase;
	public GameObject popUpGameOver;
	public GameObject popUpGameClear;
	public InGame inGame;
	//enemies
	public EnemyDetect enemyDetect;
	public SpawnerEnemy spawnEnemies;
	//
	// Use this for initialization
	void Start () {
		SupernaturalReader.AssessGhosts();

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		LvUp();
		DoSpawn();
		//detect Game Over
		if(spawnEnemies.isAttack&&watch.isMorning!=true){
			watch.isStop = true;
			popUpGameOver.SetActive(true);
			if(StaticParameter.highScore<StaticParameter.lastScore) StaticParameter.highScore = StaticParameter.lastScore;
			enemies.gameObject.SetActive(false);
		}
	}
	void DoSpawn(){
		if(enemyDetect.isSpawn){
			enemyDetect.isSpawn=false;
			spawnEnemies.SpawnEnemies();
		}
	}
	void LvUp(){
		if(watch.isTimeIncrease){
			watch.isTimeIncrease=false;
			lvUp++;
			if(lvUp>=lvUpBase){
				lvUp=0;
				enemies.LvUp();
				watch.isTimeIncrease = false;
			}
		}
		if(watch.isMorning){
			spawnEnemies.gameObject.SetActive(false);
			popUpGameClear.SetActive(true);
			if(StaticParameter.highScore<StaticParameter.lastScore) StaticParameter.highScore = StaticParameter.lastScore;
			enemies.gameObject.SetActive(false);
			inGame.CheckStage();
		}
	}
}
