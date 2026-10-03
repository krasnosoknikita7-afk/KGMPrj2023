using MV.Common;
using MV.WorldObject;
using UnityEngine;

public class MeleeWeaponHitPackage : InteractionPackage
{
	private const PlayerKilledByType killedByType = PlayerKilledByType.MeleeWeapon;

	public static InteractionData Create(float damage, Vector3 impulse)
	{
		return default;
	}

	public override void ParseAndHandlePackage(MVWorldObjectClient worldObjectClient, MVPlayer shooter, InteractionData interactionStruct)
	{
	}
}
