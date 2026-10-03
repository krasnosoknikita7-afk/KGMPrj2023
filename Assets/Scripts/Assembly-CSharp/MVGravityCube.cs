using System.Collections.Generic;

public class MVGravityCube : MVLogicObject
{
	public override bool HasInputConnector => false;

	public override bool HasOutputConnector => false;

	protected override bool HasVisualsInPlaymode => false;

	public MVGravityCube(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	public override void OnDataUpdate()
	{
	}

	public override bool IsSingletonObject()
	{
		return false;
	}

	public override void Destroy()
	{
	}
}
