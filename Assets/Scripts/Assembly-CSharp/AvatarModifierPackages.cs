using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class AvatarModifierPackages
{
	public delegate void OnModifierExpiredDelegate(AvatarModifierPackage modifier);

	[CompilerGenerated]
	private EventHandler<EventArgs> m_OnUnequipItemEvent;

	[CompilerGenerated]
	private EventHandler<EventArgs> m_OnDisableVehiclesEvent;

	public OnModifierExpiredDelegate OnModifierExpired;

	private readonly List<AvatarModifierPackage> packages;

	private bool InPause { get; set; }

	public event EventHandler<EventArgs> OnUnequipItemEvent
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

	public event EventHandler<EventArgs> OnDisableVehiclesEvent
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

	private void OnResume()
	{
	}

	private void OnPause()
	{
	}

	public void Update()
	{
	}

	public void ClearModifiers()
	{
	}

	public void ClearNonPersistantModifiers()
	{
	}

	public bool HasModifier(AvatarModifierPackageType type)
	{
		return false;
	}

	private void AddModifierPackage(AvatarModifierPackage modifierPackage, int id)
	{
	}

	public void AddModifier(AvatarModifierPackageType modifierPackageType, int id = -1, AvatarModifierPackage.AvatarModifier[] additionalModifers = null)
	{
	}

	public ModifierActions GetActionToTakeWithPackageType(AvatarModifierPackageType modifierPackageType)
	{
		return ModifierActions.Add;
	}

	private bool HandleNewAvatarModifierPackage(AvatarModifierPackage newAvatarModifierPackage)
	{
		return false;
	}

	public AvatarModifierPackageType GetPackageToActWith(AvatarModifierPackageType modifierPackageType, ModifierActions action)
	{
		return AvatarModifierPackageType.None;
	}

	private void RemoveModifierPackage(AvatarModifierPackage modifierPackage, int id)
	{
	}

	public void RemoveModifier(AvatarModifierPackageType modifierPackageType, int id = -1)
	{
	}

	public float HandleModifierEffect(AvatarModifierEffect modifierEffect, float baseValue)
	{
		return 0f;
	}

	public bool HasModifierEffect(AvatarModifierEffect modifierEffect)
	{
		return false;
	}

	public Dictionary<int, float> ComputeModifierEffectGroupedById(AvatarModifierEffect modifierEffect, float baseValue)
	{
		return null;
	}
}
