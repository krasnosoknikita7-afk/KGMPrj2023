using System.Collections.Generic;
using UnityEngine;

public class ScaleAnimations : ScaleAnimationBase
{
	[SerializeField]
	private List<ScaleAnimationBase> scaleAnimations;

	public OnScaleAnimationStoppedDelegate OnIntermediateScaleAnimationStopped;

	private int index;

	private void Awake()
	{
	}

	private void OnScaleAnimationDone(float extraTime)
	{
	}

	public override void Play(float offsetTime = 0f)
	{
	}

	private void Update()
	{
	}
}
