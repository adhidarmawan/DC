using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class SoundManager : MonoBehaviour {

	//statics
	static SoundManager _instance;
	static public bool isActive{
		get{
			return _instance != null;
		}
	}
	static public SoundManager instance{
		get{
			if(_instance == null){
				_instance = GameObject.FindObjectOfType(typeof(SoundManager)) as SoundManager;
				if(_instance == null){
					GameObject obj = new GameObject("SoundManager");
					DontDestroyOnLoad(obj);
					_instance = obj.AddComponent<SoundManager>();
					obj.AddComponent<AudioSource>();
					obj.AddComponent<AudioSource>();
					obj.AddComponent<AudioSource>();
					_instance.init();
				}
			}
			return _instance;
		}
	}

	//audios function
	static public AudioSource[] allAudio;
	static public AudioSource audioBGM;
	static public AudioSource audioSFXOnce;
	static public AudioSource audioSFXLoop;

	void init(){
		DontDestroyOnLoad(gameObject);
		allAudio = GetComponents<AudioSource>();
		audioBGM = allAudio[0];
		audioSFXLoop = allAudio[1];
		audioSFXOnce = allAudio[2];
//		readUserBGMPref ();
//		readUserSFXPref ();

	}

//	void readUserBGMPref(){
//		if(PlayerPrefs.GetInt(BaseID.BGM)==0){
//			_instance.unMuteBGM();
//		}else if(PlayerPrefs.GetInt(BaseID.BGM)==1){
//			_instance.setMuteBGM();
//		}
//	}
//	void readUserSFXPref(){
//		if(PlayerPrefs.GetInt(BaseID.SFX)==0){
//			_instance.unMuteSFXLoop();
//			_instance.unMuteSFXOnce();
//		}else if(PlayerPrefs.GetInt(BaseID.SFX)==1){
//			_instance.setMuteSFXLoop();
//			_instance.setMuteSFXOnce();
//		}
//	}

	//BGM Controller
	public void playBGMLoop(AudioClip newBGM){
		audioBGM.playOnAwake = true;
		audioBGM.loop = true;
		audioBGM.clip = newBGM;
		audioBGM.Play();
	}
	public void stopBGMLoop(){
		audioBGM.Stop();
	}
	public void setMuteBGM(){
		audioBGM.mute = true;
	}
	public void unMuteBGM(){
		audioBGM.mute = false;
	}
	//SFX loop controller
	public void playSFXLoop(AudioClip newSFXLoop){
		audioSFXLoop.loop = true;
		audioSFXLoop.clip = newSFXLoop;
		audioSFXLoop.Play();
	}
	public void setMuteSFXLoop(){
		audioSFXLoop.mute = true;
	}
	public void unMuteSFXLoop(){
		audioSFXLoop.mute = false;
	}
	public void stopSFXLoop(){
		audioSFXLoop.Stop();
	}
	//SFX once controller
	public void playSFXOnce(AudioClip newSFXOnce){
		audioSFXOnce.PlayOneShot(newSFXOnce);
	}
	public void setMuteSFXOnce(){
		audioSFXOnce.mute = true;
	}
	public void unMuteSFXOnce(){
		audioSFXOnce.mute = false;
	}
	public AudioClip getBGM(){
		return audioBGM.clip;
	}
}
