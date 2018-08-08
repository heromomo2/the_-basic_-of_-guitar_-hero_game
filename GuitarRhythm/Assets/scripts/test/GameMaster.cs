using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour {
	/// <summary>
	/// The which note.
	/// </summary>
	List<float> whichNote = new List<float>() {1,3,2,1,2,3,3,1,2,3,2,2,1,1,2,3,1,2,2,1,1,2,3,3};

	public int noteMark = 0;

	public Transform noteObj;

	public  bool timerReset = true;

	public float XPos;

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
		if ((timerReset == true) && (noteMark < whichNote.Count)) {
			StartCoroutine (spawnNote ());
			timerReset = false;


		}


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


	IEnumerator spawnNote(){
		yield return new WaitForSeconds (1);
		if (whichNote [noteMark] == 1) {
			XPos = -0.335f;
		}
		if (whichNote [noteMark] == 2) {
			XPos = -0.024f;
		}
		if (whichNote [noteMark] == 3) {
			XPos = 0.269f;
		}
		noteMark += 1;
		timerReset = true;
		Instantiate(noteObj, new Vector3( XPos,0.348f,-4.124f), noteObj.rotation);
	}
}
