using System.Collections.Generic;
using UnityEngine;

public abstract class AvatarModifier : MonoBehaviour
{
	protected float timeStamp;

	private bool isActivated;

	protected Avatar owner;

	public bool IsActivated => false;

	public bool IsLocal => false;

	public Avatar Owner => null;

	public abstract AvatarModifierPackageType ModifierType { get; }

	public static AvatarModifier CreateFromType(AvatarModifierPackageType type, Avatar owner)
	{
		return null;
	}

	public virtual bool EvaluateShouldBeAdded(Dictionary<AvatarModifierPackageType, AvatarModifier> modifiers)
	{
		return false;
	}

	public virtual void ResetTimeStamp()
	{
	}

	public void Activate(Avatar target)
	{
	}

	public void Deactivate(Avatar target)
	{
	}

	protected virtual void OnActivated(Avatar target)
	{
	}

	protected virtual void OnDeactivated(Avatar target)
	{
	}
}
