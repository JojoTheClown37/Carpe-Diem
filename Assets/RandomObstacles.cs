using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObstacles : MonoBehaviour {
	public float randomnumber;
	public Transform defaults;


	public Rigidbody obstacle1rb;
	Rigidbody obstacle1clone;
	public Rigidbody obstacle2rb;
	Rigidbody obstacle2clone;
	public Rigidbody obstacle3rb;
	Rigidbody obstacle3clone;
	public Rigidbody obstacle4rb;
	Rigidbody obstacle4clone;
	public Rigidbody obstacle5rb;
	Rigidbody obstacle5clone;
	public Rigidbody stopwatch;
	Rigidbody stopwatchclone;



	// Use this for initialization
	void Start () {
		randomnumber = 1;

		StartCoroutine (spawn ());
	}
	
	// Update is called once per frame
	void Update () {


	}
	IEnumerator spawn(){
		while (1 == 1) {
			yield return new WaitForSecondsRealtime (2F);
			randomnumber = Random.Range (1, 7);
			if (randomnumber == 1) {
				
				obstacle1clone = Instantiate (obstacle1rb, new Vector3 (3.48F, 2.7F,44.6F), defaults.rotation) as Rigidbody;
					obstacle1clone.velocity = new Vector3 (0F, -2F, -90F*Time.deltaTime);

			}
		if (randomnumber == 2) {
				
				obstacle2clone = Instantiate (obstacle2rb, new Vector3 (-0.7F, 2.25F, 44.6F), defaults.rotation) as Rigidbody;
					obstacle2clone.velocity = new Vector3 (0F, -2F, -90F*Time.deltaTime);


		}
		if (randomnumber == 3) {
				
				obstacle3clone = Instantiate (obstacle3rb,  new Vector3 (-1F, 2.25F,44.6F), defaults.rotation) as Rigidbody;
					obstacle3clone.velocity = new Vector3 (0F, -2F, -90F*Time.deltaTime);

		}
		if (randomnumber == 4) {
				
				obstacle4clone = Instantiate (obstacle4rb, new Vector3(-1F, 2.25F,44.6F), defaults.rotation) as Rigidbody;
					obstacle4clone.velocity = new Vector3 (0F, -2F, -90F*Time.deltaTime);

					
		}
		if (randomnumber == 5) {
				
				obstacle5clone = Instantiate (obstacle5rb, new Vector3 (5.15F, 2.19F,44.6F), defaults.rotation) as Rigidbody;
					obstacle5clone.velocity = new Vector3 (0F, -2F, -90F*Time.deltaTime);

		}
			if (randomnumber == 6) {

				stopwatchclone = Instantiate (stopwatch, new Vector3 (Random.Range(-4F,4F), 2.19F,44.6F), defaults.rotation) as Rigidbody;
				stopwatchclone.velocity = new Vector3 (0F, 0F, -90F*Time.deltaTime);

			}

		}
	}
}
