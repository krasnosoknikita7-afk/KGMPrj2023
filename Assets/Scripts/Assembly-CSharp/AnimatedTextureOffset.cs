using System;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedTextureOffset : ActivateOnAnimationBase
{
	[Serializable]
	private struct TextureOffsetAnimationData
	{
		public float textureOffset;

		public float frameToChangeTextureAt;

		public bool hasAlreadyTransitioned;
	}

	[SerializeField]
	private Renderer skinnedRenderer;

	[SerializeField]
	private Renderer meshRenderer;

	[SerializeField]
	private float animationFrameAmount;

	[SerializeField]
	private string triggerAnimationName;

	[SerializeField]
	private List<TextureOffsetAnimationData> textureOffsetAnimationDataList;

	[SerializeField]
	private Animation animations;

	private bool isActive;

	private float animationStartTime;

	private float previousAnimationTime;

	private float offsetRatio;

	private float currentOffset;

	private float previousOffset;

	private float timer;

	private const float updateCooldown = 0.1f;

	private const float animationsFramePerSeconds = 24f;

	protected override void Start()
	{
	}

	private void Update()
	{
	}

	public override void OnAvatarAnimationChange(string newAnimation)
	{
	}

	private bool FindAnimatedTexture()
	{
		return false;
	}

	private void UpdateAnimatedTextureOffset()
	{
	}

	private void SetTextureOffset(float offset)
	{
	}

	private void ResetTextureOffsets()
	{
	}
}
