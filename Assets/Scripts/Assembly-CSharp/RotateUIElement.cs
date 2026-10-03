using UnityEngine;

public class RotateUIElement : MonoBehaviour
{
	public float rotationSpeed;

	[SerializeField]
	private bool repeatRotationFromAngle;

	[SerializeField]
	private float resetRotationAtAngle;

	[SerializeField]
	private float repeatRotationTimeOffset;

	private Quaternion originalRotation;

	private float resettingTimestamp;

	private float lastRotationUpdate;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
