using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionMessage : Notification
{
	[SerializeField]
	private CanvasGroup canvasGroup;

	[SerializeField]
	private AnimationCurve fadeCurve;

	[SerializeField]
	private Text text;

	private float currentTime;

	private NotificationLifetime lifeTime;

	protected override NotificationLifetime Lifetime => (NotificationLifetime)0;

	public override void Initialize(Dictionary<object, object> data)
	{
	}

	private void OnEnable()
	{
	}

	protected override void Update()
	{
	}
}
