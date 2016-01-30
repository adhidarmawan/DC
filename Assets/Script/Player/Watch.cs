using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Watch : MonoBehaviour {

	public Text displayWatch;
	public SurviveClock watch;
	public float time;
	public float timeBase;
	public bool isTimeIncrease;
	public int morningTime;
	public bool isMorning;

	// Use this for initialization
	void Start () {
		watch = new SurviveClock();
		watch.hour = 20;
		watch.minute = 0;
		isMorning = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(isMorning!=true){
			if(watch.hour!=morningTime){
				CountTime();
			}else{
				isMorning = true;
			}
		}
	}
	void CountTime(){
		if(time>=timeBase){
			time=0;
			watch.minute++;
			if(watch.minute>=60){
				watch.hour++;
				watch.minute = 0;
				isTimeIncrease = true;
			}
			if(watch.hour>24){
				watch.hour = 1;
			}
			if(watch.minute<10){
				if(watch.hour<10){
					displayWatch.text = "0"+watch.hour+":0"+watch.minute;
				}else{
					displayWatch.text = watch.hour+":0"+watch.minute;
				}
			}else{
				if(watch.hour<10){
					displayWatch.text = "0"+watch.hour+":"+watch.minute;
				}else{
					displayWatch.text = watch.hour+":"+watch.minute;
				}
			}
		}
		time = time+Time.deltaTime;
	}
}

public class SurviveClock{
	public int hour;
	public int minute;
}