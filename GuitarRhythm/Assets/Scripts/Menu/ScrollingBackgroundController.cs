using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackgroundController : MonoBehaviour {
	#region Variables
	[SerializeField] private List <Transform> m_ScrollingBackgrounds = new List<Transform>();
	[SerializeField] private SpriteRenderer m_TemplateBackground;

	private Vector3 m_EndPositon;
	private Vector3 m_NewPosition;
	private int m_NewIndex = 0;
	#endregion

	private void Awake(){
		if (m_ScrollingBackgrounds.Count >0) {
			
			m_EndPositon = m_ScrollingBackgrounds [0].position;
		}
	}

	// Update is called once per frame
	private void LateUpdate () {
		for (int i = 0; i < m_ScrollingBackgrounds.Count; i++) {
			m_NewIndex = (i + m_ScrollingBackgrounds.Count-1) % m_ScrollingBackgrounds.Count;

			if(m_ScrollingBackgrounds[i].position.x < m_EndPositon.x - m_TemplateBackground.bounds.size.x){
				m_NewPosition = m_ScrollingBackgrounds [i].position;
				m_NewPosition.x = m_ScrollingBackgrounds[m_NewIndex].position.x + m_TemplateBackground.bounds.size.x;
				m_ScrollingBackgrounds[i].position = m_NewPosition;
			}
		}
	}
}
