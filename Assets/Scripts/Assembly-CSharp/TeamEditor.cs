using System.Collections.Generic;

public class TeamEditor : MVLogicObject
{
	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public override bool HasInputConnector => false;

	public override bool HasOutputConnector => false;

	protected override bool HasVisualsInPlaymode => false;

	public override bool IsSingletonObject()
	{
		return false;
	}

	public TeamEditor(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	public override void InitializeInventory()
	{
	}

	public override void OnDataUpdate()
	{
	}

	private void UpdateTeamNamesFromData()
	{
	}

	public override void Destroy()
	{
	}
}
