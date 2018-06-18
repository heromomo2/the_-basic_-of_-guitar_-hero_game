using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour {
	/// <summary>
	/// The timer text U.
	/// </summary>
	private GameObject TimerTextUI;
	void Awake() {

		TimerTextUI = GameObject.Find ("TimerTextUI").GetComponent<Text>();

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//TimerTextUI = gameObject.GetComponent<Text>("yes");
	}
}
