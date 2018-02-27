using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gm : MonoBehaviour {

	List<float> whichNote = new List<float>() {1,6,3,4,2,5,2,1,2,3,5,6,4,6,5,5,1,2,4,1,1,4,5,5};

	public int noteMark = 0;

	public Transform noteObj;

	public string timerReset = "y";

	public float XPos;

	public static int winStreak = 0;

	public Transform fountainFW;

	public Transform fountainFW2;

	public string  fountainSpawn = "n";

	public string  fountainSpawn2 = "n";

	public static float totalscore = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if ((timerReset == "y")&& (noteMark < whichNote.Count) ) 
		{
			StartCoroutine (spawnNote ());
			timerReset = "n";
		}

		if ((winStreak == 3) &&( fountainSpawn == "n")){
			fountainSpawn = "y";
			Instantiate (fountainFW, new Vector3 (-2.2f, 0.69f, -4.19f), fountainFW.rotation);
		}

		if ((winStreak == 6) &&( fountainSpawn2 == "n")){
			fountainSpawn2 = "y";
			Instantiate (fountainFW2, new Vector3 (-1.66f, 2.19f, -3.08f), fountainFW2.rotation);
		}
	}


	IEnumerator spawnNote(){
		yield return new WaitForSeconds (1);
		if (whichNote [noteMark] == 1) 
		{
			XPos = -1.62f;
		}
		if (whichNote [noteMark] == 2) 
		{
			XPos = -1.07f;
		}
		if (whichNote [noteMark] == 3) 
		{
			XPos = -0.47f;
		}
		if (whichNote [noteMark] == 4) 
		{
			XPos = 0.12f;
		}
		if (whichNote [noteMark] == 5) 
		{
			XPos = 0.65f;
		}
		if (whichNote [noteMark] == 6) 
		{
			XPos = 1.2f;
		}
		noteMark += 1;
		timerReset = "y";
		Instantiate(noteObj, new Vector3( XPos,1.32f,-2.11f), noteObj.rotation);
	}
}
