using UnityEngine;

public class ScaleAnimationBase : MonoBehaviour
{
	public delegate void OnScaleAnimationStoppedDelegate(float extraTime);

	protected enum State
	{
		None = 0,
		Stopped = 1,
		Playing = 2
	}

	protected State state;

	protected Vector3 originalScale;

	[SerializeField]
	protected Transform target;

	[SerializeField]
	private State testState;

	public OnScaleAnimationStoppedDelegate OnScaleAnimationStopped;

	public Vector3 OriginalScale => default;

	public void ResetScaleAnimation()
	{
	}

	protected void Test()
	{
	}

	public virtual void Play(float offsetTime = 0f)
	{
	}

	public void SetTarget(Transform target)
	{
	}
}
