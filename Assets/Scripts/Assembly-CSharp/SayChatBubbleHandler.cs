using System.Collections.Generic;
using UnityEngine;

public class SayChatBubbleHandler : MonoBehaviour
{
	[SerializeField]
	private MeshRenderer sayChatBubble;

	private const float SayHearingDistance = 50f;

	private bool isActive;

	private bool isIndicatorActive;

	private int ownerActorNr;

	private ChatAnchor chatAnchor;

	public ChatAnchor ChatAnchor => null;

	public void Initialize(int actorNr, ChatAnchor chatAnchor)
	{
	}

	public void Activate()
	{
	}

	public void Deactivate()
	{
	}

	private void OnSayChatMessageReceived(int actorNr, Dictionary<object, object> data)
	{
	}

	private void SetSayBubbleIndicatorVisibility(int actorNr, bool shouldBeVisible)
	{
	}

	private bool IsPlayerInHearingDistance()
	{
		return false;
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}
}
