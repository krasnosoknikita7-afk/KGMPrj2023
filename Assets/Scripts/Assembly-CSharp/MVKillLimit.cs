using System.Collections.Generic;

public class MVKillLimit : MVGamePointRewardLogicObject
{
	private bool initializedInWorld;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	protected override bool HasVisualsInPlaymode => false;

	private int KillLimit => 0;

	protected override int GamePointRewardAmount => 0;

	public MVKillLimit(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
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
