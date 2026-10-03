using System;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimation : MoveAnimationBase
{
	private float beginTime;

	private float doneTime;

	private Vector3 direction;

	[SerializeField]
	private List<KeyFrameCallback> keyFrameCallbacks;

	[SerializeField]
	private AnimationCurve animationCurve;

	[SerializeField]
	private Transform moveTo;

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

	public void SubscribeToKeyFrame(string keyFrameName, Action callback)
	{
	}

	private void EvaluateKeyFrameCallbacks(float timePassedSincePlay)
	{
	}
}
