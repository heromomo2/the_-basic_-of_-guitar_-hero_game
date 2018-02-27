using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class string1 : MonoBehaviour {

	public KeyCode activateString;
	public string LockInput = "n";
	public  static string releaseKey = "n";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetKeyDown (activateString)) &&  (LockInput == "n")) {
			LockInput = "y";

			GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, 2);
			StartCoroutine (retractCollider ());

			releaseKey = "n";
		}

		if ((Input.GetKeyUp (activateString))) {
			releaseKey = "y";
		}
	}
	IEnumerator retractCollider(){
		
		yield return new WaitForSeconds (0.75f);

	   GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, 0);

		if (releaseKey == "n") {
			
			yield return new WaitForSeconds (1);
			StartCoroutine (releaseNote ());
		}

		if (releaseKey == "y") 
		{
			StartCoroutine (releaseNote ());
		}


		LockInput = "n";
	}

	IEnumerator releaseNote(){
		GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, -2);
		yield return new WaitForSeconds (0.75f);
		GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, 0);
	}
}
