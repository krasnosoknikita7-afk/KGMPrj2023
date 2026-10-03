using UnityEngine;

public class FirstTimeCubeModelBlinker : BlinkerBase
{
	private MVCubeModelBase targetCubeModelBase;

	public void Initialize(Material material, Camera targetCamera, MVCubeModelBase targetCubeModelBase)
	{
	}

	protected override void BeforeDraw()
	{
	}
}
