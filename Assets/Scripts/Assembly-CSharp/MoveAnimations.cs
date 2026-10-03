using System.Collections.Generic;
using UnityEngine;

public class MoveAnimations : MoveAnimationBase
{
	[SerializeField]
	private List<MoveAnimationBase> moveAnimations;

	public OnMoveAnimationStoppedDelegate OnIntermediateMoveAnimationStopped;

	private int index;

	private void Awake()
	{
	}

	private void OnMoveAnimationDone(float extraTime)
	{
	}

	public override void Play(float offsetTime = 0f)
	{
	}

	private void Update()
	{
	}
}
