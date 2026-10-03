using UnityEngine;

public class PickupParticleScaler : MonoBehaviour
{
	[SerializeField]
	private PickupItem itemAttachedTo;

	[SerializeField]
	private ParticleSystem particleSysToScale;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnScaleChange(MVWorldObjectClient obj, ScaleChangedEventArgs args)
	{
	}
}
