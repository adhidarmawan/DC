using UnityEngine;
using System.Collections;

public class BGMPlayer : MonoBehaviour {

	public AudioClip bgm;
	public AudioClip testSFX;
	public int delayTime;
	//int delay;

	void Start(){
		playBGM();
		//delay=0;
	}

	public void playBGM(){
		if(SoundManager.instance.getBGM()!=bgm){
			SoundManager.instance.playBGMLoop(bgm);
		}
	}

	public void stopBGM(){
		SoundManager.instance.stopBGMLoop();	
	}
}
