using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrolligbackground : MonoBehaviour {

	private GameObject[] backgroundkids;
	private Transform [] layers;

	private int Index;
	public float speed;

	void Start () {
		layers = new Transform[transform.childCount];
		
	}
	
	// Update is called once per frame
	void Update () {
		Index = 0;
		moveobject ();
	}
	void moveobject(){
		layers [Index].Translate((Vector3.right * speed) * Time.deltaTime);
	}

}
