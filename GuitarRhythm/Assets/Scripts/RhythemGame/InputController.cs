using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; 

public class InputController : Singleton<InputController>  {
	#region Properties
	public delegate void OnInputFire ();
	public event OnInputFire OnPressCenterString;
	public event OnInputFire OnPressLeftString;
	public event OnInputFire OnPressRightString;
	#endregion

	private void Update()
	{
		GetInput ();
	}

	private void GetInput()
	{
		if (Input.GetKeyDown(KeyCode.A))
		{
			if (OnPressLeftString != null)
			{
				OnPressLeftString ();
			}
		} 

		if (Input.GetKeyDown(KeyCode.W))
		{
			if (OnPressCenterString != null)
			{
				
				OnPressCenterString ();
			}

		}

		if (Input.GetKeyDown(KeyCode.D))
		{
			if (OnPressRightString != null)
			{
				OnPressRightString ();
			}
		}
	}
}
