using UnityEngine;

public class AvatarAccessoryBackAccessories : AvatarAccessory
{
	private Transform attachPosTfm;

	private AccessoryBackAccessoriesSettings wingSettings;

	public override bool HasAttachmentPoint => false;

	public AccessoryBackAccessoriesSettings WingSettings => null;

	public override AccessorySettings AccessorySettings => null;

	public override Vector3 AttachmentPointWorldPos => default;

	protected override void Awake()
	{
	}
}
