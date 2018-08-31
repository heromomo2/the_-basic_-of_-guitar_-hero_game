using System.Collections;
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
	#endregion
	[SerializeField] private MainMeun FirstSelect; 
	#region Public Funtion 
	public void OpenPlayMeun()
	{
		m_MainMeunCanvas.enabled = true ; 
		m_OptionMeunGeneralCanvas.enabled = false;
		m_OptionMeunVideoCanvas.enabled = false;
		m_OptionMeunAudioCanvas.enabled = false;
		FirstSelect.Index = 0;
		FirstSelect.FirstSelect ();
	}

	public void OpenOptionMeun()
	{
		m_MainMeunCanvas.enabled = false ; 
		m_OptionMeunGeneralCanvas.enabled = true;
		m_OptionMeunVideoCanvas.enabled = false;
		m_OptionMeunAudioCanvas.enabled = true;
		FirstSelect.Index = 1;
		FirstSelect.FirstSelect ();
	}

	public void OpenVideoMeun()
	{   m_MainMeunCanvas.enabled = false ; 
		m_OptionMeunGeneralCanvas.enabled = true;
		m_OptionMeunVideoCanvas.enabled = true;
		m_OptionMeunAudioCanvas.enabled = false;
	}

	public void LoadA( string scenename)
	{
		Debug.Log ("sceneName to load:" + scenename);
		SceneManager.LoadScene (scenename);
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
