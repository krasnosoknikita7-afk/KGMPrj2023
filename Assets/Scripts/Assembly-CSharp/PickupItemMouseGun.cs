using MV.Common;
using MV.WorldObject;

public class PickupItemMouseGun : SizeGunBase
{
	public override AvatarItemType Type => AvatarItemType.LaserPointer;

	protected override InteractionData GetPackageData()
	{
		return default;
	}
}
