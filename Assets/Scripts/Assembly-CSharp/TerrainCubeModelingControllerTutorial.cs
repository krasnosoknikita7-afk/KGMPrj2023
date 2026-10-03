using UnityEngine;
using UnityEngine.UI;

public class TerrainCubeModelingControllerTutorial : MonoBehaviour
{
	private MaterialsController materialsController;

	[SerializeField]
	private RawImage materialsButtonImage;

	[SerializeField]
	private DesktopCubeModelingToolsController desktopCubeModelingController;

	public void Initialize(CubeModelingStateMachine cubeModelingStateMachine, MaterialsController materialsController)
	{
	}

	private void SetMaterial(byte materialId)
	{
	}

	private void OnDestroy()
	{
	}
}
