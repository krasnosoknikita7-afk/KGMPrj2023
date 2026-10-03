using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public class AvatarUIHandler : MonoBehaviour
{
	protected ChatAnchor chatBubbleAnchor;

	protected MVWorldObjectClient worldObject;

	protected int ownerActorNr;

	protected bool shouldShowUI;

	public virtual void Initialize(bool isLocal, MVWorldObjectClient wo, int ownerActorNr, ChatAnchor chatBubbleAnchor)
	{
	}

	public virtual void Activate()
	{
	}

	public virtual void Deactivate()
	{
	}

	public virtual void OnPositionChanged(MVWorldObjectClient arg0, PositionChangedEventArgs positionChangedEventArgs)
	{
	}

	public void OnSayChatMessageRecieved(int actorNr, Dictionary<object, object> data)
	{
	}

	private void HandleTeamChange(object sender, TeamEventArgs eventArgs)
	{
	}

	public virtual void HandleTeamChange()
	{
	}

	public virtual void SetShouldShowUI(bool shouldShow)
	{
	}

	public void ForceDestroy()
	{
	}

	protected virtual void OnDestroy()
	{
	}
}
