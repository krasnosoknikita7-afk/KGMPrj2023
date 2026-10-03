using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EditorWorldObjectCreation : MonoBehaviour, ICloneHandler, IEventSystemHandler, IAddItemFromInventory, ICreateNewPrototype, IChangePrototypeScale
{
	[SerializeField]
	private ThemeRepository themeRepository;

	private EditorStateMachine esm;

	public void Initialize(EditorStateMachine esm)
	{
	}

	public void Clone(MVWorldObjectClient original, bool cloneToRoot, bool setAsPreviewItem, bool goToInsert = false)
	{
	}

	public void OnAddItemFromInventory(InventoryItem item)
	{
	}

	private static KoGaMaPackageClient GetKoGaMaPackageFromItem(InventoryItem item)
	{
		return null;
	}

	public void OnAddNewPrototype(string name, float scale)
	{
	}

	private void CloneWorldObjectTreeResponseHandler(object sender, CloneWorldObjectTreeResponseEventArgs e)
	{
	}

	private bool ValidateAddItemFromInventory(KoGaMaPackageClient package)
	{
		return false;
	}

	private bool IsItemAnAllowedWinningCondition(MVWorldObjectClient worldObject)
	{
		return false;
	}

	private bool IsWinningConditionPlaceable<T>() where T : WinningCondition
	{
		return false;
	}

	private List<MVWorldObjectClient> GetPlacedWinningConditions()
	{
		return null;
	}

	private void WOCM_InitializedGameQueryData(object sender, InitializedGameQueryDataEventArgs e)
	{
	}

	public void OnChangePrototypeScale(int worldId, float scale)
	{
	}
}
