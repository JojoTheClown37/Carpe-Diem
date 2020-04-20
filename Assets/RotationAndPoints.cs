using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotationAndPoints : MonoBehaviour {
	public Transform StopWatchT;
	public GameObject ThisObject;
	public float points;
	// Use this for initialization
	void Start () {
		points = 0;
	}
	
	// Update is called once per frame
	void Update () {
		StopWatchT.Rotate (0, 300F * Time.deltaTime, 0);
		if (transform.position.y < 0){
			DestroyObject (ThisObject);
		}



	}
	void OnCollisionEnter (Collision col){

		if (col.gameObject.tag == "Player"){	
		points = 1;
		//rotates the light backward

		//updats the actual time
		GameObject LeftTime = GameObject.FindGameObjectWithTag ("TimeLeft");
		TimeLeft AddTime = LeftTime.GetComponent <TimeLeft> ();
		AddTime.points = 1;

		Collider.DestroyObject (ThisObject);
	}
	}
}
