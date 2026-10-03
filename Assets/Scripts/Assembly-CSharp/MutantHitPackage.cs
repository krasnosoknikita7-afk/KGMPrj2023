using MV.WorldObject;

public class MutantHitPackage : InteractionPackage
{
	public static InteractionData Create()
	{
		return default;
	}

	public override void ParseAndHandlePackage(MVWorldObjectClient worldObjectClient, MVPlayer shooter, InteractionData interactionStruct)
	{
	}
}
