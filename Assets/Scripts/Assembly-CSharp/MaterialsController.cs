using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class MaterialsController : MonoBehaviour, IMaterialClicked, IEventSystemHandler, IHandleMaterial
{
	protected CubeModelingStateMachine cubeModelingStateMachine;

	private TabState tab;

	private InventoryController inventoryController;

	protected DesktopCubeModelingController desktopCubeModelingController;

	[SerializeField]
	private InventoryController inventoryControllerPrefab;

	[SerializeField]
	private DesktopCubeModelingController desktopCubeModelingControllerPrefab;

	[SerializeField]
	private int numberOfSlotsPrPage;

	[SerializeField]
	private MaterialViewItem materialViewItemPrefab;

	public UnityAction<byte> materialChange;

	public UnityAction materialsPop;

	public void Initialize(CubeModelingStateMachine cubeModelingStateMachine)
	{
	}

	public virtual Transform SetActive()
	{
		return null;
	}

	public void Push(UIPushOption pushOption, UnityAction onPop)
	{
	}

	public virtual void OnMaterialChanged(byte id)
	{
	}

	public void ShowMaterialInventory()
	{
	}

	public void ShowMaterialInventoryFirstPage()
	{
	}

	public void OnMaterialClicked(byte materialID)
	{
	}

	private void ShowInventory(UIPushOption pushOption, int page = 1)
	{
	}

	public void PageTurned(int dir)
	{
	}

	public void UpdateContent()
	{
	}

	private void InitializeMaterialInventoryData()
	{
	}

	private void OnPop()
	{
	}
}
