using MV.Common;

public class VehicleInteractable : MVInteractable, IMoveHitHandler
{
	public override void TakeDamage(float amount, MVPlayer damageDealer, PlayerKilledByType damageType)
	{
	}

	public override void TakeDamageOverTime(AvatarModifierPackageType type, MVPlayer damageDealer, PlayerKilledByType damageType)
	{
	}

	public override void AddModifier(AvatarModifierPackageType type, int id = -1, AvatarModifierPackage.AvatarModifier[] additionalModifers = null)
	{
	}

	public void HandleMoveHit(MVControllerColliderHit moveHit)
	{
	}
}
