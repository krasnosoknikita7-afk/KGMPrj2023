using UnityEngine;

public class TeleportGroup : MonoBehaviour
{
	public LineRenderer lineRenderer;

	private MVTeleportGroup worldObject;

	public void Initialize(MVTeleportGroup owner)
	{
	}

	private void OnDestroy()
	{
	}

	private void PositionChanged(object sender, PositionChangedEventArgs args)
	{
	}
}
