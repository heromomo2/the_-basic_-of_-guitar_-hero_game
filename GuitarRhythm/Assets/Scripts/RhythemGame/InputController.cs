using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; 

public class InputController : Singleton<InputController>  {
	#region Properties
	// talk to carlo about OnInputFire
	public delegate void OnInputFire ();
	public event OnInputFire OnPressCenterString;
	public event OnInputFire OnPressLeftString;
	public event OnInputFire OnPressRightString;
	public event OnInputFire OnPressGameMenu;
	#endregion

	private void Update()
	{
		// GetInput function  is been called every frame.
		GetInput ();
	}

	private void GetInput()
	{
		if (Input.GetKeyDown (KeyCode.A)) 
		{
			/*OnPressLeftString event need not be null for the code in curly brackets to used */
			if (OnPressLeftString != null)
			{
				// call this event
				OnPressLeftString ();
			}
		} 

		if (Input.GetKeyDown(KeyCode.W))
		{
			/*OnPressCenterString event need not be null for the code in curly brackets to used */
			if (OnPressCenterString != null)
			{
				// call this event
				OnPressCenterString ();
			}

		}

		if (Input.GetKeyDown(KeyCode.D))
		{
			/*OnPressRightString event need not be null for the code in curly brackets to used */
			if (OnPressRightString != null)
			{
				// call this event
				OnPressRightString ();
			}
		}

		if (Input.GetKeyDown(KeyCode.P))
		{
			/*OnPressRightString event need not be null for the code in curly brackets to used */
			if (OnPressRightString != null)
			{
				// call this event
				OnPressGameMenu();
			}
		}
	}
}
