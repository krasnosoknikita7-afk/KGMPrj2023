using UnityEngine;

public class LineRangeIndicator : MonoBehaviour
{
	[Header("Configuration")]
	[SerializeField]
	private float lineDotDensity;

	[SerializeField]
	private float lineWidth;

	[SerializeField]
	[Header("Dependencies")]
	private MeshRenderer rangeIndicator;

	[SerializeField]
	private MeshRenderer rangeIndicator_backside;

	[SerializeField]
	private Material lineDotMaterial;

	private Material materialCopy;

	protected void Awake()
	{
	}

	private void CopyMaterial()
	{
	}

	public void SetRange(float range)
	{
	}
}
