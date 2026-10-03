using System.Collections.Generic;
using UnityEngine;

public class AvatarSelectionAnimator : MonoBehaviour
{
	public List<MVBody> Bodies;

	public MVSpawnPointRed bodySpawnPoint;

	public Vector3 displayPos;

	public Vector3 hidePos;

	public Quaternion displayRotation;

	private int currentIndex;

	private int targetIndex;

	private float time;

	private float baseTimeMultiplier;

	private Vector3 distance;

	private bool forward;

	private float timeSlowThreshold;

	private float endmultiplier;

	private float addition;

	private float SuperspeedFactor;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SetTargetIndex(int currentIndexInp, int TargetIndexInp)
	{
	}

	public void SetTargetIndexNoAnim(int oldindex, int TargetIndexInp)
	{
	}

	private int GetNextIndex()
	{
		return 0;
	}
}
