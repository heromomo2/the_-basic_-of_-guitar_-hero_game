using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMover: MonoBehaviour {
	
	private Vector3 m_StartPosition;
	private Vector3 m_TargetPosition;

	private float m_TimeToTarget = 0;
	private float m_Time = 0;

	public float TimeToTarget
	{
		set { m_TimeToTarget = value;}
	}
	public Vector3 StartPosition
	{
		set { m_StartPosition = value;}
	}
	public Vector3 Target
	{
		set { m_TargetPosition = value;}
	}


	private void Start () 
	{
		m_Time = 0;	
	}

	public void MoveUpdate ()
	{

		m_Time += Time.deltaTime;
		transform.position = Vector3.Lerp (m_StartPosition, m_TargetPosition, m_Time / m_TimeToTarget);
	}

	public void ClaimNote ()
	{
		Destroy (this.gameObject);
	}
}
