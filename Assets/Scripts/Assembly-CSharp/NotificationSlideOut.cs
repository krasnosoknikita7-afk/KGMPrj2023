using UnityEngine;

public class NotificationSlideOut : MonoBehaviour
{
	[SerializeField]
	private Notification notification;

	[SerializeField]
	private Vector2 slideVelocity;

	[SerializeField]
	[Range(0f, 1f)]
	private float slideOutStartTime;

	private void OnValidate()
	{
	}

	protected void Update()
	{
	}
}
