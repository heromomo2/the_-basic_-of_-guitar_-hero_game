using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Carlo_NewSong", menuName = "Carlo_RhythmGame/Song", order = 1)]
public class Carlo_SongChart : ScriptableObject {

    [SerializeField]
    private List<string> m_Rows = new List<string>();
    [SerializeField]
    private float m_Time = 0;

    public List<string> Rows
    {
        get { return m_Rows; }
    }

    public float Time
    {
        get { return m_Time; }
    }

    [ContextMenu("Reverse Rows")]
    private void Reverse()
    {
        m_Rows.Reverse();
    }
}
