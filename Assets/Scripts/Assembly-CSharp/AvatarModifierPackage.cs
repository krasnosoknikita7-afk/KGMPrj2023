using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;

public struct AvatarModifierPackage
{
	public struct AvatarModifier
	{
		public AvatarModifierType avatarModifierType;

		public AvatarModifierEffect avatarModifierEffect;

		public Func<float> value;

		public AvatarModifier(AvatarModifierType avatarModifierType, AvatarModifierEffect avatarModifierEffect, Func<float> value)
		{
			this.avatarModifierType = AvatarModifierType.Multiply;
			this.avatarModifierEffect = AvatarModifierEffect.Density;
			this.value = null;
		}
	}

	public int id;

	public ObscuredFloat duration;

	public AvatarModifier[] avatarModifiers;

	public Dictionary<AvatarModifierPackageType, ModifierActions> actionsToTakeVsTypes;

	private ObscuredFloat timeStamp;

	public bool persistant;

	private float lastTimeStamp;

	private AvatarModifierPackageType avatarModifierPackageType;

	private AvatarModifierPackageAdditionPolicy avatarModifierPackageAdditionPolicy;

	public static string[] AvatarModifierPackageTypeLookupTable;

	public AvatarModifierPackageType AvatarModifierPackageType => AvatarModifierPackageType.None;

	public AvatarModifierPackageAdditionPolicy AvatarModifierPackageAdditionPolicy => AvatarModifierPackageAdditionPolicy.Add;

	public bool IsExpired
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsEqualTo(AvatarModifierPackage other)
	{
		return false;
	}

	public AvatarModifierPackage(AvatarModifierPackageType avatarModifierPackageType, AvatarModifierPackageAdditionPolicy avatarModifierPackageAdditionPolicy, float duration, AvatarModifier[] avatarModifiers, Dictionary<AvatarModifierPackageType, ModifierActions> actionsToTakeVsTypes = null, bool persist = false)
	{
		id = 0;
		this.duration = default;
		this.avatarModifiers = null;
		this.actionsToTakeVsTypes = null;
		timeStamp = default;
		persistant = false;
		lastTimeStamp = 0f;
		this.avatarModifierPackageType = AvatarModifierPackageType.None;
		this.avatarModifierPackageAdditionPolicy = AvatarModifierPackageAdditionPolicy.Add;
	}

	public void InPause()
	{
	}

	public void Renew()
	{
	}
}
