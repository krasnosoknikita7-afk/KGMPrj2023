using UnityEngine;

public class PendingFriendRequestAnimation : MonoBehaviour
{
	[SerializeField]
	private RectTransform maskTransform;

	[SerializeField]
	private RectTransform friendRequestImageTransform;

	[SerializeField]
	private float moveAmount;

	[SerializeField]
	private float dotAnimationCooldown;

	[SerializeField]
	private int dotAmount;

	private float lastDotAnimationTime;

	private int currentDot;

	private void Update()
	{
	}

	private void MoveAnimation(float amount)
	{
	}
}
