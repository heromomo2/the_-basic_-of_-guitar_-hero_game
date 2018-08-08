using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; 

public class ExtendButtons: Button {


	public delegate void ExtendedButtons();
	public event ExtendedButtons OnButtonSelect;
	public event ExtendedButtons OnButtonDeSelect;

	// Use this for initialization
	public override void OnSelect(BaseEventData eventData)
	{
		base.OnSelect (eventData);
    		//OnButtonSelect();
		if( OnButtonSelect != null)
		{
			OnButtonSelect ();
		}
		
	}
	public override void OnDeselect(BaseEventData eventData)
	{
		base.OnDeselect (eventData);
		//OnButtonDeSelect();
		if( OnButtonDeSelect != null)
		{
			OnButtonDeSelect();
		}

	}




}
