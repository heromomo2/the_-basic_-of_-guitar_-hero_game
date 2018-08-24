using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; 

public class MainMeun : MonoBehaviour {
	[SerializeField] public int Index;
	[SerializeField] private List<Selectable> m_StartUIElements = new List<Selectable> ();
	[SerializeField] private Selectable m_StartUIElement;

	//Use this for initialization
	//public BaseEventData eventData
	private void Start () {
		if (m_StartUIElements != null) {
			m_StartUIElements[Index].Select ();
		}
	}

	public void FirstSelect () {
		if (m_StartUIElements != null) {
			m_StartUIElements[Index].Select();


		}
	}
	

}
