using System.Collections.Generic;
using UnityEngine;

public class MVCubeGun : MVPickupItemBase
{
	private CubeBullet cubeBullet;

	public MVCubeGun(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null)
	{
	}

	protected override void AddExtraUseRequirements(GameObject root, UseInteractor ui)
	{
	}

	private void SetCubeMaterial()
	{
	}

	public override void OnDataUpdate()
	{
	}
}
