using MV.Common;
using MV.WorldObject;
using UnityEngine;

public abstract class InteractionPackage
{
	public abstract void ParseAndHandlePackage(MVWorldObjectClient worldObjectClient, MVPlayer shooter, InteractionData interactionStruct);

	protected void HandlePackage(MVWorldObjectClient target, MVPlayer shooter, float damage, PlayerKilledByType killedByType, Vector3 impulse, AvatarModifierPackageType modType)
	{
	}

	protected void HandlePackage(MVWorldObjectClient target, MVPlayer shooter, float damage, PlayerKilledByType killedByType, Vector3 impulse)
	{
	}

	protected void HandlePackage(MVWorldObjectClient target, MVPlayer shooter, float damage, PlayerKilledByType killedByType)
	{
	}

	protected void HandlePackage(MVWorldObjectClient target, MVPlayer shooter, Vector3 impulse, AvatarModifierPackageType modifierType)
	{
	}

	protected void HandlePackage(MVWorldObjectClient target, Vector3 impulse, AvatarModifierPackageType modifierType)
	{
	}

	protected void HandlePackage(MVWorldObjectClient target, MVPlayer shooter, Vector3 impulse)
	{
	}

	protected void HandlePackage(MVWorldObjectClient target, MVPlayer shooter, AvatarModifierPackageType modifierType)
	{
	}

	protected bool IsValidTarget(MVPlayer shooter, MVWorldObjectClient target, MVInteractableBase targetInteractable)
	{
		return false;
	}

	private bool IsSpawnProtected(MVInteractableBase targetInteractable)
	{
		return false;
	}
}
