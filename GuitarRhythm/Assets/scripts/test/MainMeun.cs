using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; 

public class MainMeun : MonoBehaviour {


	[SerializeField] private Selectable m_StartUIElement;

	//Use this for initialization
	public BaseEventData eventData;
	private void Start () {
		if (m_StartUIElement != null) {
			m_StartUIElement.Select ();

		
		}
	}
	

}
