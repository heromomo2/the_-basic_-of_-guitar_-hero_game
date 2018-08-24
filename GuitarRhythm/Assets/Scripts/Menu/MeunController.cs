using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class MeunController : MonoBehaviour {
	

	#region  Variable for Canvas
	[SerializeField] private Canvas m_OptionMeunGeneralCanvas;
	[SerializeField] private Canvas m_OptionMeunVideoCanvas;
	[SerializeField] private Canvas m_OptionMeunAudioCanvas;
	[SerializeField] private Canvas m_MainMeunCanvas;
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
	{  m_MainMeunCanvas.enabled = false ; 
		m_OptionMeunGeneralCanvas.enabled = true;
		m_OptionMeunVideoCanvas.enabled = false;
		m_OptionMeunAudioCanvas.enabled = true;
		FirstSelect.Index = 1;
		FirstSelect.FirstSelect ();
	}

	public void OpenVideoMeun()
	{  m_MainMeunCanvas.enabled = false ; 
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
	#endregion



}
