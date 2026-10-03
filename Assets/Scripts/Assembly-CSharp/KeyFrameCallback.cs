using System;
using UnityEngine;

public class KeyFrameCallback : MonoBehaviour
{
	[SerializeField]
	private string keyFrameName;

	[SerializeField]
	private int keyFrameIndex;

	public Action callbacks;

	private bool fired;

	public string KeyFrameName => null;

	public int KeyFrameIndex => 0;

	public void Reset()
	{
	}

	public bool Evaluate(float timePassedSincePlay, AnimationCurve animationCurve)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
