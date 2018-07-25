using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformMover : MonoBehaviour {
	#region Variables
	[SerializeField] private float m_Speed;
	[SerializeField] private Vector3 m_Direction;
	#endregion

	// Update is called once per frame
	void Update () {
		transform.Translate(m_Direction * m_Speed * Time.deltaTime);
	}
}
