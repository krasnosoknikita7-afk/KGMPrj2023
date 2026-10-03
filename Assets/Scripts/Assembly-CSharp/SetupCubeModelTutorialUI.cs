using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class SetupCubeModelTutorialUI : MonoBehaviour, IHandleCubeEditTutorial, IEventSystemHandler
{
	protected CubeModelingStateMachine cubeModelingStateMachine;

	[SerializeField]
	private DesktopCubeModelingControllerCubeTutorial desktopCubeModelTutorialControllerPrefab;

	[SerializeField]
	private MaterialsController materialsController;

	public void Initialize(CubeModelingStateMachine cubeModelingStateMachine)
	{
	}

	public void PushCubeEditCubeTutorialTools(UnityAction closeAction)
	{
	}
}
