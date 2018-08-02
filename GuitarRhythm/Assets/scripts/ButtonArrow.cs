using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonArrow : MonoBehaviour {

	private ExtendButtons m_Button;

	[SerializeField] private GameObject m_Arrow;

	// Use this for initialization

	private void Start()
	{
		m_Button = GetComponent<ExtendButtons> ();
		m_Button.OnButtonSelect += ShowArrow;
		m_Button.OnButtonDeSelect += HideArrow;

		HideArrow ();
	}

	private void OnDestroy(){
		if (m_Button != null) 
		{
			m_Button.OnButtonSelect -= ShowArrow;
			m_Button.OnButtonDeSelect -= HideArrow;
		}
	}


	private void ShowArrow () {

		if (m_Arrow != null)
		{
			m_Arrow.SetActive (true);
		}


	}
	private void HideArrow () {

		if (m_Arrow != null)
		{
			m_Arrow.SetActive (false);
		}


	}
	

}
