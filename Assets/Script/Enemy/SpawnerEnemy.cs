using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnerEnemy : MonoBehaviour {

	public List<GameObject> listEnemies;
	
	public void SpawnEnemies(){
		int enemyType = Random.Range(0,listEnemies.Count);
		GameObject typeEnemies = listEnemies[enemyType];
		GameObject newEnemies = new GameObject();
		newEnemies.transform.SetParent(this.gameObject.transform);
		newEnemies = GameObject.Instantiate(typeEnemies);
		newEnemies.SetActive(true);
	}
}
