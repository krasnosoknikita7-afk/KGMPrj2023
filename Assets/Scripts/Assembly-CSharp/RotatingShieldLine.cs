using UnityEngine;

public class RotatingShieldLine : MonoBehaviour
{
	[SerializeField]
	private Transform lineTransform;

	[SerializeField]
	private Vector3 lineRotationSpeed;

	[SerializeField]
	private ParticleSystem orbSpawner;

	[SerializeField]
	private int segments;

	[SerializeField]
	private float radius;

	[SerializeField]
	private LineRenderer line;

	private Vector3[] positions;

	private int currIndex;

	private bool recreatOrbs;

	public void Initialize()
	{
	}

	public void OnSetHidden()
	{
	}

	public void OnSetVisible()
	{
	}

	private void CreatePoints()
	{
	}

	private void Update()
	{
	}
}
