using System;
using System.Collections.Generic;
using MV.Common;

public class ClientSideNPCInteractable : MVInteractableBase
{
	private static readonly Dictionary<AvatarModifierPackageType, float> allowedModifiersDictionary;

	private Action<float, MVPlayer, PlayerKilledByType> takeDamageCallback;

	private int respawnInterval;

	private float maxHealth;

	public void Init(Action<float, MVPlayer, PlayerKilledByType> takeDamageCallback)
	{
	}

	public bool IsDead()
	{
		return false;
	}

	public override void TakeDamage(float amount, MVPlayer damageDealer, PlayerKilledByType damageType)
	{
	}

	public override void TakeDamageOverTime(AvatarModifierPackageType type, MVPlayer damageDealer, PlayerKilledByType damageType)
	{
	}

	public void Reset()
	{
	}

	public override void AddModifier(AvatarModifierPackageType type, int id, AvatarModifierPackage.AvatarModifier[] additionalModifers = null)
	{
	}

	public override bool HasModifier(AvatarModifierPackageType type)
	{
		return false;
	}

	public override void RemoveModifier(AvatarModifierPackageType type, int id)
	{
	}

	public override bool HasModifierEffect(AvatarModifierEffect type)
	{
		return false;
	}

	public override float HandleModifierEffect(AvatarModifierEffect avatarModifierEffect, float baseValue)
	{
		return 0f;
	}

	public override void ClearModifiers()
	{
	}
}
