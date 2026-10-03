using System.Collections.Generic;
using UnityEngine;

public class FirstTimeSetupTerrainEditTutorial : FirstTimeActivatableElementBase
{
	[SerializeField]
	private List<UIPushOption> pushOptions;

	[SerializeField]
	private TerrainCubeModelingControllerTutorial terrainCubeModelingControllerTutorialPrefab;

	private CubeModelingStateMachine cubeModelingStateMachine;

	private MaterialsController materialsController;

	public override bool CanShow => false;

	public override void OnShow()
	{
	}

	public void Initialize(CubeModelingStateMachine cubeModelingStateMachine, MaterialsController materialsController)
	{
	}
}
