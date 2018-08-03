using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonArrow : MonoBehaviour {

	private ExtendButtons m_Button;

	[SerializeField] private GameObject m_Arrow;

	[SerializeField] private Text m_ButtonText;
	//[SerializeField] private List <float> SelectTextRGB  = new List<float>();
	//[SerializeField] private List <float> DeselectTextRGB  = new List<float>();

	// Use this for initialization

	private void Start()
	{
		m_Button = GetComponent<ExtendButtons> ();
		m_Button.OnButtonSelect += ShowArrow;
		m_Button.OnButtonDeSelect += HideArrow;

		//m_Button.OnButtonSelect += SelectText;
		//m_Button.OnButtonDeSelect += DeselectText;

		HideArrow ();
	}

	private void OnDestroy(){
		if (m_Button != null) 
		{
			m_Button.OnButtonSelect -= ShowArrow;
			m_Button.OnButtonDeSelect -= HideArrow;

			//m_Button.OnButtonSelect -= SelectText;
			//m_Button.OnButtonDeSelect -= DeselectText;
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

/*	private void SelectText () {

		if (m_ButtonText != null &  SelectTextRGB != null  &  SelectTextRGB.Count > 3)
		{
			m_ButtonText.color =  new Color( SelectTextRGB[0], SelectTextRGB[1], SelectTextRGB[2]);
		}


	}


	private void DeselectText () {

		if (m_ButtonText != null &  DeselectTextRGB != null  &  DeselectTextRGB.Count > 3)
		{
			m_ButtonText.color =  new Color( DeselectTextRGB[0], DeselectTextRGB[1],  DeselectTextRGB[2]);
		}


	}*/
	

}
