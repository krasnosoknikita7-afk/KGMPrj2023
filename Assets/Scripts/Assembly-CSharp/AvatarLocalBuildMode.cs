using UnityEngine;

public class AvatarLocalBuildMode : MonoBehaviour
{
	[SerializeField]
	private AvatarCamerasDesktopBuildMode avatarCamerasDesktopPrefab;

	private AvatarCamerasDesktopBuildMode avatarCamerasDesktop;

	[SerializeField]
	private AvatarEnabledChangeHandler enabledChangeHandler;

	public AvatarEnabledChangeHandler EnabledChangeHandler => null;

	public AvatarCamerasDesktopBuildMode AvatarCamerasDesktopBuildMode => null;

	public void Initialize(MVBuildModeAvatarLocal buildModeAvatar)
	{
	}

	public void Activate()
	{
	}
}
