using MV.WorldObject;
using UnityEngine;

public class SixShooterHitPackage : InteractionPackage
{
	public static InteractionData Create(Vector3 impulse)
	{
		return default;
	}

	public override void ParseAndHandlePackage(MVWorldObjectClient worldObjectClient, MVPlayer shooter, InteractionData interactionStruct)
	{
	}
}
