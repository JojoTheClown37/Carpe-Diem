
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MusicScript : MonoBehaviour {

	public float setting;
	public float timeleft;

	public AudioSource AudioUpbeat;
	public AudioSource AudioSlowerBeat;
	public AudioSource AudioMoody;

	void start() 
	{

	//code for 'setting' here
		setting = 0;


	}

	void Update(){

		if (setting == 1) {
			AudioSlowerBeat.Stop ();
			AudioMoody.Stop ();
			if (AudioUpbeat.isPlaying == false) {
				AudioUpbeat.Play ();
				}

			}
		if (setting == 2) {
			AudioUpbeat.Stop ();
			AudioMoody.Stop ();
			if (AudioSlowerBeat.isPlaying == false) {
				AudioSlowerBeat.Play ();
			}
		}
		if (setting == 3) {
				AudioSlowerBeat.Stop ();
				AudioUpbeat.Stop ();
				if (AudioMoody.isPlaying == false) {
					AudioMoody.Play ();
				}

			}
		
		//pulls from the script containing the time left
		GameObject UI = GameObject.FindGameObjectWithTag ("TimeLeft");
		TimeLeft timeremaining = UI.GetComponent <TimeLeft>();
		timeleft = timeremaining.RemainingTime;

		if (timeleft > 40) {
			setting = 1;
		} else if (timeleft > 20 && timeleft < 40) {
			setting = 2;
		} else if (timeleft < 20) {
			setting = 3;
		}

	//	Debug.Log (setting);
}
}

