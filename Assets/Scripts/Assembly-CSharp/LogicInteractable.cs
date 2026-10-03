using System;
using System.Runtime.CompilerServices;
using MV.Common;

public class LogicInteractable : MVInteractableBase
{
	[CompilerGenerated]
	private EventHandler<TakeDamageEventArgs> m_OnDamageEvent;

	public event EventHandler<TakeDamageEventArgs> OnDamageEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public override void TakeDamage(float amount, MVPlayer damageDealer, PlayerKilledByType damageType)
	{
	}

	public override void TakeDamageOverTime(AvatarModifierPackageType type, MVPlayer damageDealer, PlayerKilledByType damageType)
	{
	}

	public override void AddModifier(AvatarModifierPackageType type, int id = -1, AvatarModifierPackage.AvatarModifier[] additionalModifers = null)
	{
	}

	public override bool HasModifier(AvatarModifierPackageType type)
	{
		return false;
	}

	public override void RemoveModifier(AvatarModifierPackageType type, int id = -1)
	{
	}

	public override float HandleModifierEffect(AvatarModifierEffect avatarModifierEffect, float baseValue)
	{
		return 0f;
	}

	public override void ClearModifiers()
	{
	}

	public override bool HasModifierEffect(AvatarModifierEffect avatarModifierEffect)
	{
		return false;
	}
}
