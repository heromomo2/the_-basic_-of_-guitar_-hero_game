﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
public class MeunController : MonoBehaviour {
	
	[SerializeField] private  GameController  GameController;
	[SerializeField] private List<Button>ButtonList = new List<Button>();
	[SerializeField] private  bool m_IsStartSong = false;


	#region  Variable for Canvas
	[SerializeField] private Canvas m_OptionMeunGeneralCanvas;
	[SerializeField] private Canvas m_OptionMeunVideoCanvas;
	[SerializeField] private Canvas m_OptionMeunAudioCanvas;
	[SerializeField] private Canvas m_MainMeunCanvas;
	[SerializeField] private Canvas m_GameMenu;
	[SerializeField] private Canvas m_PlayMenuCanvas;
	#endregion

	[SerializeField] private MainMeun FirstSelect; 

	#region Public Funtion 
	public void OpenPlayMeun()
	{
		Debug.Log("OpenPlayMeun is being call 1");
		if(m_MainMeunCanvas != null && m_OptionMeunGeneralCanvas != null && m_OptionMeunVideoCanvas != null 
			&& m_OptionMeunAudioCanvas != null && m_PlayMenuCanvas != null )
		{
		m_PlayMenuCanvas.enabled = true; 	
		m_MainMeunCanvas.enabled = false; 
		m_OptionMeunGeneralCanvas.enabled = false;
		m_OptionMeunVideoCanvas.enabled = false;
		m_OptionMeunAudioCanvas.enabled = false;
		Debug.Log("OpenPlayMeun is being call 2");
		//FirstSelect.Index = 0;
		//FirstSelect.FirstSelect ();
		}
	}

	public void OpenMainMeun()
	{
		if(m_MainMeunCanvas != null && m_OptionMeunGeneralCanvas != null && m_OptionMeunVideoCanvas != null 
			&& m_OptionMeunAudioCanvas != null && m_PlayMenuCanvas  != null)
		{
			m_PlayMenuCanvas.enabled = false; 	
			m_MainMeunCanvas.enabled = true; 
			m_OptionMeunGeneralCanvas.enabled = false;
			m_OptionMeunVideoCanvas.enabled = false;
			m_OptionMeunAudioCanvas.enabled = false;
			FirstSelect.Index = 0;
			FirstSelect.FirstSelect ();
		}
	}

	public void OpenOptionMeun()
	{
		if(!m_MainMeunCanvas.enabled == null && !m_OptionMeunGeneralCanvas == null && !m_OptionMeunVideoCanvas == null 
			&& !m_OptionMeunAudioCanvas == null)
		{
			m_MainMeunCanvas.enabled = false; 
			m_OptionMeunGeneralCanvas.enabled = true;
			m_OptionMeunVideoCanvas.enabled = false;
			m_OptionMeunAudioCanvas.enabled = true;
			FirstSelect.Index = 1;
			FirstSelect.FirstSelect ();
		}
	}

	public void OpenVideoMeun()
	{  
		if(!m_MainMeunCanvas.enabled == null && !m_OptionMeunGeneralCanvas == null && !m_OptionMeunVideoCanvas == null 
			&& !m_OptionMeunAudioCanvas == null)
		{
			m_MainMeunCanvas.enabled = false; 
			m_OptionMeunGeneralCanvas.enabled = true;
			m_OptionMeunVideoCanvas.enabled = true;
			m_OptionMeunAudioCanvas.enabled = false;
		}
	}

	public void LoadA( string scenename )
	{
		if ( SongData.Instance.SelectSong != null) 
		{
			Debug.Log ("sceneName to load:" + scenename);
			SceneManager.LoadScene (scenename);
		} 
		else 
		{
			Debug.Log ("NO Song was seleted");
		}
	}

	public void Quit()
	{
	 	Application.Quit ();
	}

	public void StartGame()
	{
		if (m_IsStartSong) 
		{
			ButtonList [0].interactable = false;
			ButtonList [1].interactable = true;
		}
		else 
		{
			ButtonList [1].interactable = true;;
			ButtonList [0].interactable= false;
		}
		m_GameMenu.enabled = false;
		GameController.StartSong ();
	}
	public void OpenGameMenu()
	{
		m_GameMenu.enabled = true;
	}

	#endregion



}
