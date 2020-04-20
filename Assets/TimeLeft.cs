using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeLeft : MonoBehaviour {
	public TextMesh TimeRemaining;
	public float RemainingTime;
	public TextMesh TimeElapsed;
	public float ElapsedTime;
	public float R;
	public GameObject Player;
	public float points;
	// Use this for initialization
	void Start () {
		TimeRemaining.text = "Time Left: 60";
		TimeElapsed.text = "Time Elapsed: 0";
		RemainingTime = 60;
		ElapsedTime = 0;
		R = 1;
		points = 0;
		StartCoroutine (CountSeconds());

	}
	
	// Update is called once per frame
	void Update () {
		if (points == 1) {
	
			RemainingTime = RemainingTime + 3F;
			points = 0;
			GameObject Light = GameObject.FindGameObjectWithTag ("Light");
			DayAndNightCycle SubtractTime = Light.GetComponent <DayAndNightCycle>();
			SubtractTime.points = 1;
		}
		//Debug.Log (RemainingTime);
	}
	IEnumerator CountSeconds()
	{
		while (R == 1) {
			yield return new WaitForSecondsRealtime (1F);
			RemainingTime = RemainingTime - 1F;
			ElapsedTime = ElapsedTime + 1F;
			TimeRemaining.text = ("Time Left: ") + RemainingTime;
			TimeElapsed.text = ("Time Elapsed: ") + ElapsedTime;
			//Debug.Log (RemainingTime);
			if (RemainingTime == 0F) {
				R = 2;
				DestroyObject (Player);
			}
	

		}
		}
}
