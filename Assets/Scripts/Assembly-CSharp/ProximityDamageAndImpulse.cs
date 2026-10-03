using MV.Common;
using MV.WorldObject;
using UnityEngine;

public class ProximityDamageAndImpulse : InteractionPackage
{
	public static InteractionData Create(float damage, Vector3 impulse, PlayerKilledByType playerKilledByType = PlayerKilledByType.None)
	{
		return default;
	}

	public override void ParseAndHandlePackage(MVWorldObjectClient worldObjectClient, MVPlayer shooter, InteractionData interactionStruct)
	{
	}
}
