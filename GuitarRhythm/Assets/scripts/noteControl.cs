using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteControl : MonoBehaviour {

	public Transform sucessbust;
	public Transform failbust;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "failcollder") 
		{
			Destroy (gameObject);
			Debug.Log("Fail!!");
			Instantiate (failbust, transform.position, failbust.rotation);
			gm.totalscore -= 1;
		}
		if (other.gameObject.name == "sucess") 
		{
			Debug.Log ("sucess1 hit");
			Destroy (gameObject);
			Instantiate (sucessbust, transform.position, sucessbust.rotation);
			gm.winStreak += 1;
			gm.totalscore += 10;
		}
		
	}
}
