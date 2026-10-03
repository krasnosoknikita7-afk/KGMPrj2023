using UnityEngine;

public class MVBodyObject : ObjectPrefab
{
	[SerializeField]
	private BoneAnimation boneAnimation;

	[SerializeField]
	private AvatarBlobShadowController avatarBlobShadowController;

	[SerializeField]
	private AvatarBlinker avatarBlinker;

	[SerializeField]
	private BodyData bodyData;

	public BoneAnimation BoneAnimation => null;

	public AvatarBlobShadowController AvatarBlobShadowController => null;

	public AvatarBlinker AvatarBlinker => null;

	public BodyData BodyData => null;
}
