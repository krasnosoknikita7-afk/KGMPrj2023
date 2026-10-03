using UnityEngine;

public class ScaleAnimation : ScaleAnimationBase
{
	private float beginTime;

	[SerializeField]
	private AnimationCurve animationCurve;

	private float doneTime;

	public override void Play(float offsetTime = 0f)
	{
	}

	private void Stopped(float extraTime)
	{
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
