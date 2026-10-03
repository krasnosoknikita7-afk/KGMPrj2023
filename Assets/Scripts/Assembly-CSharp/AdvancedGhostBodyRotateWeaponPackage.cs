using MV.WorldObject;
using UnityEngine;

public class AdvancedGhostBodyRotateWeaponPackage : InteractionPackage
{
	public static InteractionData Create(float damage, Vector3 impulse)
	{
		return default;
	}

	public override void ParseAndHandlePackage(MVWorldObjectClient worldObjectClient, MVPlayer shooter, InteractionData interactionStruct)
	{
	}
}
