using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public SpawnerEnemy spawner;
	public bool isAttack=false;
	public int enemyType;
	public PopScores popScore;

	public AudioClip sfxAttack;
	public AudioClip sfxExorcised;

	void OnMouseDown(){
		SoundManager.instance.playSFXOnce(sfxAttack);
		popScore.PopUpScores(enemyType);
		Debug.Log("Exorcised");
		StaticParameter.ghostEradicated++;
		StaticParameter.lastScore = StaticParameter.lastScore+(enemyType*100);
		SoundManager.instance.playSFXOnce(sfxExorcised);
		spawner.listEnemies.Remove(this.gameObject);
		Destroy(this.gameObject);
	}
	public void EnemyAttack(){
		isAttack = true;
		spawner.isAttack = true;
		Debug.Log("attack");
	}
}
