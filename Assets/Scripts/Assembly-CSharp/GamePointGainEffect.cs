using UnityEngine;
using UnityEngine.Events;

public class GamePointGainEffect : MonoBehaviour
{
	[SerializeField]
	private float targetSpeedAccelerationPerSec;

	[SerializeField]
	private float randomOffsetMaxSpeed;

	[SerializeField]
	private float randomOffsetMinSpeed;

	private float targetSpeed;

	private float offsetSpeed;

	private Vector3 offsetDirection;

	private Transform targetTransform;

	private UnityAction<int> onReachCallbackCallback;

	private int id;

	public int ID => 0;

	public void Initialize(UnityAction<int> onReachCallbackCallback, int id)
	{
	}

	public void StartEffect(Transform tr, float offsetDirectionXMin = -0.6f, float offsetDirectionXMax = 0.6f, float offsetDirectionYMin = -0.8f, float offsetDirectionYMax = 0.8f)
	{
	}

	private void Update()
	{
	}

	private void UpdateOffsetSpeed()
	{
	}

	private void UpdateTargetSpeed()
	{
	}
}
