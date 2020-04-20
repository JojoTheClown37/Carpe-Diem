using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stopwatchmove : MonoBehaviour {
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		rb.AddForce (0, 0, -1500F*Time.deltaTime);
		if (this.transform.position.y < -10F) {
			Destroy (this);
		}
	}
}
