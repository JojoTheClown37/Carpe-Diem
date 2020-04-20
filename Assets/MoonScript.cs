using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoonScript : MonoBehaviour {
	public float time;

	// Use this for initialization
	void Start () {
		time = 60F;
	}
	
	// Update is called once per frame
	void Update () {
		GameObject LeftTime = GameObject.FindGameObjectWithTag ("TimeLeft");
		TimeLeft RemainingTime = LeftTime.GetComponent <TimeLeft> ();
		time = RemainingTime.RemainingTime;
		if (time < 10) {
			if (time == 0) {
			
			} else {
				this.transform.Translate (0F, 1F * Time.deltaTime, 0F);
			}
			} else if (time > 10) {
			this.transform.position = new Vector3(-0.7170531F, -1.87F, -45.35F);
		}
	}
}
