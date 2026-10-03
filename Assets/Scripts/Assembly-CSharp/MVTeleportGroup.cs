using System.Collections.Generic;

public class MVTeleportGroup : MVBlueprintBase
{
	private MVTeleporter teleporter1;

	private MVTeleporter teleporter2;

	public MVTeleporter Teleporter1 => null;

	public MVTeleporter Teleporter2 => null;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public MVTeleportGroup(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null)
	{
	}

	public override void Initialize()
	{
	}

	private MVTeleporter RetrieveTeleporter(Dictionary<object, object> table, string id)
	{
		return null;
	}

	public override void SetWorldObjectToPurchased()
	{
	}

	public override void AddPreviewBox()
	{
	}

	private void AddPreviewBoxesToTeleporters()
	{
	}
}
