using UnityEngine;

public class ObjectiveArrow : MonoBehaviour
{
	[SerializeField]
	private float animationSpeed;

	[SerializeField]
	private Vector3 arrowOffset;

	[SerializeField]
	private AnimationCurve bobbleCurve;

	[SerializeField]
	private AnimationCurve animationSpawnCurve;

	[SerializeField]
	private float animationLerpTime;

	[SerializeField]
	private float distanceScale;

	private Vector3 initialScale;

	private Vector3 startPos;

	private Transform targetPickup;

	private Transform targetDropOff;

	private float initialHeight;

	private float farPlane;

	private float animationTimer;

	public void Initialize(Vector3 startPos, Transform dropOff, Transform pickup)
	{
	}

	public void OnPositionChanged(MVWorldObjectClient wo, PositionChangedEventArgs args)
	{
	}

	private void Update()
	{
	}

	private void UpdateLerpAnimation()
	{
	}

	private void UpdateArrowTransform()
	{
	}

	private void MoveInDirection(Vector3 dir, float dist)
	{
	}

	private void SetArrowBobbing(float dist)
	{
	}

	private void SetScaleFromDistance(float dist)
	{
	}
}
