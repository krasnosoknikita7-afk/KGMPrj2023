using UnityEngine;

public class HackingToolDetectorSO : ScriptableObject
{
	[Tooltip("Scans per second.")]
	[SerializeField]
	private float scanFrequency;

	public float ScanFrequency => 0f;
}
