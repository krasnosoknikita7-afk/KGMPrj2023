using UnityEngine;

public class SentryGunBeam : MonoBehaviour
{
	public LineRenderer lineRenderer;

	private const float timeout = 1f;

	private float deleteTimer;

	public bool Active { get; set; }

	public Vector3 StartPosition { get; private set; }

	public Vector3 EndPosition { get; private set; }

	public static SentryGunBeam Create(SentryGunBeam prefab, SentryGunBeamType beamType, MVSentryGun owner)
	{
		return null;
	}

	protected virtual void OnUpdate()
	{
	}

	private void Update()
	{
	}

	public void RefreshTime()
	{
	}

	public void SetBeamPositions(Vector3 start, Vector3 end)
	{
	}
}
