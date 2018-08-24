using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour {

	public static MusicController Instance { get; private set;}

	#region Variables
	public AudioSource m_AudioSource; 
	[SerializeField] private List <AudioClip> m_AudioClip = new List<AudioClip>(); 
	public bool m_IsPlaying;
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

	public void PlayAudio(){
		m_AudioSource.Play();
	}

	public void SwitchAudio(){
		m_AudioSource.clip =  m_AudioClip[m_Index];
	}

	public void EndAudio(){
		m_AudioSource.Stop ();
	}
}
