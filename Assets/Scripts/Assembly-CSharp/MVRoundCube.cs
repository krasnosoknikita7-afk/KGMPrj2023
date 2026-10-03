using System;
using System.Collections.Generic;

public class MVRoundCube : MVLogicObject
{
	private bool initializedInWorld;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public int DurationInMilliseconds => 0;

	protected override bool HasVisualsInPlaymode => false;

	public MVRoundCube(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	public override bool IsSingletonObject()
	{
		return false;
	}

	public override void Destroy()
	{
	}

	public int GetTimeLeft()
	{
		return 0;
	}

	public string MakeTimeIntoText(int time)
	{
		return null;
	}

	private void OnResetWorldDone(object sender, EventArgs e)
	{
	}
}
