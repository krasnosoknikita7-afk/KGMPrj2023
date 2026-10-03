using System.Collections.Generic;
using UnityEngine;

public class MVMovingPlatformNode : MVWorldObjectClient
{
	public MVMovingPlatformNode Previous { get; set; }

	public MVMovingPlatformNode Next { get; set; }

	public MVMovingPlatformNode(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base((Dictionary<object, object>)null, (GameObject)null, (Dictionary<int, MVWorldObjectClient>)null)
	{
	}

	public override void Select(Color color)
	{
	}

	public override Bounds GetLocalBounds(BoundsContext boundsContext)
	{
		return default;
	}

	public override bool Delete(MVWorldObjectClientManager WOCM, ref string errorText)
	{
		return false;
	}
}
