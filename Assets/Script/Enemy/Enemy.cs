using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public bool isAttack=false;

	void OnMouseDown(){
		Debug.Log("Exorcised");
		StaticParameter.ghostEradicated++;
		Destroy(this.gameObject);
	}
	public void EnemyAttack(){
		Debug.Log("attack");
	}
}
