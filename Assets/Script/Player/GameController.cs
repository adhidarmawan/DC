using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public bool isGameOver;
	public Watch watch;
	public SpawnController enemies;
	public int lvUp;
	public int lvUpBase;
	public GameObject popUpGameOver;
	public GameObject popUpGameClear;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
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
			popUpGameClear.SetActive(true);
			enemies.gameObject.SetActive(false);
		}
	}
}
