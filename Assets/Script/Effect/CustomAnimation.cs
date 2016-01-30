using UnityEngine;
using System.Collections;

public class CustomAnimation : MonoBehaviour {
	public Animator animator;

	public void StopAnimation(){
		animator.Stop();
	}
}
