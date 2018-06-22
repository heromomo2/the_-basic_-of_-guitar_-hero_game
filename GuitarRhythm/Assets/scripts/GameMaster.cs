using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour {
	/// <summary>
	/// The timer text U.
	/// </summary>
	[SerializeField]private  bool   startTimer = false;
	[SerializeField]private  Text   TimerTextUI;
	[SerializeField]private  float  GameTimer;
	[SerializeField]private  float  GameTimermintues;
	[SerializeField]private  float  GameTimerseconds;
	void Awake() {

	

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (startTimer == true) {
			GameTimer += Time.deltaTime;
			Mastertimer ();
		}
	}

	void Mastertimer(){
		GameTimermintues = Mathf.Floor(GameTimer / 60);
		GameTimerseconds = GameTimer % 60;

		TimerTextUI.text= "Gametimer: "+ GameTimermintues.ToString("00")+"m:"+
			GameTimerseconds.ToString("00")+"s";
	}
}
