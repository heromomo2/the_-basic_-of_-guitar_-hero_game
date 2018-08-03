using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour {

	public static MusicController Instance { get; private set;}

	#region Variables
	public AudioSource A_Source; 
	[SerializeField] private List <AudioClip> m_AudioClip = new List<AudioClip>(); 
	public bool IsPlaying;
	public int m_Index;
	#endregion



	private void Awake()
	{
		if (Instance == null) 
		{
			Instance = this;
			DontDestroyOnLoad (gameObject);
		} 
		else 
		{
			Destroy(gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		SwitchAudio ();
		PlayAudio ();
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}

	void PlayAudio(){
		A_Source.Play();
	}

	void SwitchAudio(){
		A_Source.clip =  m_AudioClip[m_Index];
	}

	void EndAudio(){
		A_Source.Stop ();
	}
}
