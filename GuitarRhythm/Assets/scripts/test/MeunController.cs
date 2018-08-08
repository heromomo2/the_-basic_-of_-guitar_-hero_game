using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class MeunController : MonoBehaviour {



	public void OpenPlayMeun()
	{
		

	}

	public void OpenOptionMeun()
	{
		

	}
	public void LoadA( string scenename)
	{
		Debug.Log ("sceneName to load:" + scenename);
		SceneManager.LoadScene (scenename);


	}

	public void Quit()
	{
		Application.Quit();

	}




}
