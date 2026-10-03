using UnityEngine;

public class AvatarRemoteBuildMode : MonoBehaviour
{
	[SerializeField]
	private AvatarUIHandlerRemote avatarUIHandlerRemote;

	[SerializeField]
	private ChatAnchor chatBubbleAnchor;

	[SerializeField]
	private AvatarEnabledChangeHandler enabledChangeHandler;

	public AvatarEnabledChangeHandler EnabledChangeHandler => null;

	public void Initialize(int ownerActorNr, MVBuildModeAvatar avatar)
	{
	}

	private void OnPositionChanged(MVWorldObjectClient arg0, PositionChangedEventArgs positionChangedEventArgs)
	{
	}

	public void Activate()
	{
	}

	public void Deactivate()
	{
	}
}
