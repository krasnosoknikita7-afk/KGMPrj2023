using UnityEngine;

public class InputMovementPrecisionModifier : MonoBehaviour
{
	[SerializeField]
	private AnimationCurve inputMovementModificationCurve;

	private float maxMagnitude;

	private void Start()
	{
	}

	private void SetReferenceResolution(Vector2 referenceResolution)
	{
	}

	public Vector3 GetPrecisionInput(Vector3 input)
	{
		return default;
	}
}
