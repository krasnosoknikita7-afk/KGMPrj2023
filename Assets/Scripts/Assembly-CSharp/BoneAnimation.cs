using System;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animation))]
public class BoneAnimation : MonoBehaviour
{
	public Action<string> OnAnimationChange;

	private const int REMOTE_ANIM_SPEEDUP = 20;

	private const float walkAnimationMinSpeed = 0.5f;

	private const float walkAnimationMaxSpeed = 1.1f;

	private const float animationWalkSpeed = 8f;

	private float fallbackWalkSpeed;

	private MVAvatar mvAvatar;

	private bool isLocal;

	private AudioSource audioSource;

	private Queue<AnimationData> animationQueue;

	private AnimationData prevAnim;

	private AnimationData currentAnim;

	private AnimationData nextAnim;

	private HashSet<string> playingAnimations;

	private bool pauseNextFrame;

	private int playStartFrame;

	[SerializeField]
	private Animation avatarAnimation;

	private Camera mainCamera;

	public AudioSource AudioSource => null;

	public float FallBackWalkSpeed
	{
		set
		{
		}
	}

	private void Start()
	{
	}

	public void PlayFootstepAudio()
	{
	}

	private float GetFootstepPitch()
	{
		return 0f;
	}

	public void Attach(MVAvatar mvAvatar, bool isLocal)
	{
	}

	public void Detach()
	{
	}

	public void AnimationChangeHandler(object animData)
	{
	}

	public void StartAnimation(string newAnimation, int timeStamp)
	{
	}

	public void ComputeBlendAnimation(Dictionary<object, object> animData)
	{
	}

	private void OnEnable()
	{
	}

	private void ComputeAnimation()
	{
	}

	private void ComputeRemoteAnimation()
	{
	}

	public void Play(string animationName)
	{
	}

	public void PlayAndPauseAt(string animationName, float time)
	{
	}

	public float GetAnimationTime(string animation)
	{
		return 0f;
	}

	public void Stop()
	{
	}

	public bool IsPlaying(string animationName)
	{
		return false;
	}

	private void Update()
	{
	}
}
