using UnityEngine;

public class AvatarAccessoryHat : AvatarAccessory
{
	private Transform attachPosTfm;

	private AccessoryHatSettings hatSettings;

	public override bool HasAttachmentPoint => false;

	public AccessoryHatSettings HatSettings => null;

	public override AccessorySettings AccessorySettings => null;

	public override Vector3 AttachmentPointWorldPos => default;

	protected override void Awake()
	{
	}
}
