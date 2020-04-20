using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayAndNightCycle : MonoBehaviour {

//	private IEnumerator coroutine;
	public Transform LightT;
	public int R = 1;
	public float TimeValue;
	public float TimeRate;
	public float RotateRate;
	public float points;

	// Use this for initiaization
	void Start () {
		TimeValue = 0;
		TimeRate = 0.1F;
		RotateRate = 60F*0.189394F;
	//	coroutine = RotateLight ();
		points = 0;
		StartCoroutine (RotateLight());
	}

	private IEnumerator RotateLight(){
		while (R == 1) {
			LightT.Rotate (0, RotateRate*Time.deltaTime, 0);
			yield return new WaitForSecondsRealtime (TimeRate);
			TimeValue = TimeValue + 0.17761098934F;
			//TimeValue 100 = nighttime



		
		}
		}
	void Update(){
		if (points == 1) {
			points = 0;
			TimeValue = TimeValue - 5;
			LightT.Rotate (0, -0.66812F, 0);
		}
		//Debug.Log (TimeValue);
	}
}
