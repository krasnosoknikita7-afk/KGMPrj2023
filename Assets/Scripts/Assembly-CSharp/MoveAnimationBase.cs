using UnityEngine;

public class MoveAnimationBase : MonoBehaviour
{
	public delegate void OnMoveAnimationStoppedDelegate(float extraTime);

	protected enum State
	{
		None = 0,
		Stopped = 1,
		Playing = 2
	}

	protected State state;

	[SerializeField]
	protected Transform target;

	protected Vector3 originalLocalPos;

	public OnMoveAnimationStoppedDelegate OnMoveAnimationStopped;

	[SerializeField]
	private State testState;

	public virtual void Play(float offsetTime = 0f)
	{
	}

	protected void Test()
	{
	}

	public void SetTarget(Transform target)
	{
	}
}
