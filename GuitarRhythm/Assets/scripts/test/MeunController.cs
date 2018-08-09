using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class MeunController : MonoBehaviour {

	#region  Variable for Canvas
	[SerializeField] private Canvas OptionMeunGeneralCanvas;
	[SerializeField] private Canvas MainMeunCanvas;
	#endregion

	public void OpenPlayMeun()
	{
		MainMeunCanvas.enabled = true ; 
		OptionMeunGeneralCanvas.enabled = false;

	}

	public void OpenOptionMeun()
	{  MainMeunCanvas.enabled = false ; 
		OptionMeunGeneralCanvas.enabled = true;
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




}
