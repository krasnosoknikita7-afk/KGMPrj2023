using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class MaterialsControllerEditMode : MaterialsController, IHandleCubeModelEdit, IEventSystemHandler
{
	[SerializeField]
	private CreateCubeModelController createCubeModelController;

	[SerializeField]
	private DesktopCubeModelingController desktopCubeModelingControllerEditCubeModelPrefab;

	public static byte targetMaterial;

	private DesktopCubeModelingController desktopCubeModelingControllerEditMode;

	private UnityAction closeCallback;

	private byte prevMaterial;

	private void OnEnable()
	{
	}

	public override Transform SetActive()
	{
		return null;
	}

	public void Open(UnityAction closeCallback)
	{
	}

	public override void OnMaterialChanged(byte id)
	{
	}

	public void Close()
	{
	}

	private void PlayModeToggleOverwrite()
	{
	}

	private void OnPop()
	{
	}
}
