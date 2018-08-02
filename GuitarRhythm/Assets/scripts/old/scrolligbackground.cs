using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrolligbackground : MonoBehaviour {

	private Transform cameraTranform;
	public Renderer  m_Renderer;
	public float loopspotstart;
	public float loopspotend;
	public float speed;

	void Start () {
		cameraTranform = Camera.main.transform;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		moveobject ();
	}
	void moveobject(){
		this.gameObject.transform.Translate((Vector3.right * speed) * Time.deltaTime);
		loop ();
	}
	void loop(){
		if (this.gameObject.transform.position.x > loopspotend) {

			this.gameObject.transform.position = new Vector3(loopspotstart,0.0f,0.0f);
		}
	}
}
