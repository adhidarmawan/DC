using UnityEngine;
using System.Collections;

public class EnemyDetect : MonoBehaviour {

	public Collision PlayerRadius;
	public Collider PlayerCollider;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision collision){
		Debug.Log("collison");
	}

	void OnColliderEnter(Collider collider){
		Debug.Log("collider");
	}
	void OnParticleCollision(GameObject particle){
		DestroyObject(particle);
		Debug.Log("particle");
	}
}
