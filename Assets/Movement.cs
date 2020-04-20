using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour {

	public Transform Move;
	public Rigidbody rb;
	public float scalefactor;
	public GameObject ThisObject;
	// Use this for initialization
	void Start () {
		scalefactor = 1500F;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("a")) {
			rb.AddForce (-scalefactor*Time.deltaTime, 0F, 0F);
		}
		if (Input.GetKey ("d")) {
			rb.AddForce (scalefactor*Time.deltaTime, 0F, 0F);
		}

	}
	void OnCollisionEnter (Collision col){
		if (col.gameObject.CompareTag ("Obstacle")){

			//stops the day from proceeding
			GameObject Light = GameObject.FindGameObjectWithTag ("Light");
			DayAndNightCycle Stop = Light.GetComponent <DayAndNightCycle>();
			Stop.R = 2;
			GameObject Time = GameObject.FindGameObjectWithTag ("TimeLeft");
			TimeLeft StopTime = Time.GetComponent <TimeLeft>();
			StopTime.R = 2;


		Collider.DestroyObject (ThisObject);
		//Player Has Lost.
		}

	}
}