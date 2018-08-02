using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour {

	#region Variables
	[SerializeField] private List <AudioClip> m_AudioClip = new List<AudioClip>();
	public AudioSource A_Source; 
	public bool IsPlaying;
	public bool m_Index;
	#endregion


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	if (IsPlaying) {
			PlayAudio ();
			IsPlaying = false;
		}
	}

	void PlayAudio(){
		A_Source.Play ();
	}

	void EndAudio(){
		A_Source.Stop ();
	}
}
