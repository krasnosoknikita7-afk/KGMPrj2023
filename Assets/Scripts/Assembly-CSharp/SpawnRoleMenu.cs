using System;
using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;
using UnityEngine.UI;

public class SpawnRoleMenu : LobbyFlowMenu, IDragInputReciever
{
	[SerializeField]
	private RectTransform elementContainer;

	[SerializeField]
	private Scrollbar scrollbar;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private DragInputHandler dragInputReciever;

	[SerializeField]
	private SpawnRoleSelectionButtonController buttonController;

	[SerializeField]
	private GameObject backButton;

	[SerializeField]
	private DefaultSpawnRoleSelectionElement defaultSelectionElementPrefab;

	[SerializeField]
	private SpawnRoleSelectionElement selectionElementPrefab;

	[SerializeField]
	private TierUnlockDetailsPopup tierUnlockPopupPrefab;

	[SerializeField]
	private TierTestDetailsPopup tierTestPopupPrefab;

	[SerializeField]
	private TierLockedDetailsPopup tierLockedPopupPrefab;

	[SerializeField]
	private float selectionElementWidth;

	[SerializeField]
	private float elementSpacing;

	[SerializeField]
	private int maxSelectionElementsOnScreen;

	private List<DefaultSpawnRoleSelectionElement> SelectionElementsList;

	private int selectedSpawnRole;

	private float interpolateToPositionX;

	private float interpolationStartTime;

	private bool shouldInterpolate;

	private float menuHalfWidth;

	private float dragStartPositionX;

	private int currentSelectionStartIndex;

	private bool awaitingSpawn;

	private MVTeam shownTeam;

	public static Action<int> OnNewSpawnRoleSelected;

	protected override LobbyFlowMenuType MenuType => LobbyFlowMenuType.LobbyState;

	public void OnBeginDrag()
	{
	}

	public void OnEndDrag()
	{
	}

	public void OnDrag()
	{
	}

	public void OnScrollValueChange()
	{
	}

	private void UpdateShownElements()
	{
	}

	private bool IsIndexWithinBounds(int index)
	{
		return false;
	}

	private void ShowElements(int startElementIndex)
	{
	}

	private void HideElements(int previousStartElement, int amountOfElements, int newStartElement)
	{
	}

	public void OnSelectButtonPressed()
	{
	}

	public void OpenTierShopButtonPressed()
	{
	}

	public void LockedButtonPressed()
	{
	}

	public void HideBackButton()
	{
	}

	public override void Start()
	{
	}

	public void Initialize(MVTeam team)
	{
	}

	protected override void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void CreateSpawnRoleSelectionElement(int startIndex, int index, List<ISpawnRolePreviewObject> sortedSpawnRoles, List<MVWorldObjectClient> sortedWorldObjects)
	{
	}

	private void CreateDefaultAvatarElement()
	{
	}

	private void OnSpawnRoleSelected(int newSelectedSpawnRole)
	{
	}

	private void OnSpawnRoleActivated(int newSelectedSpawnRole)
	{
	}

	private void RecalculateInterpolation(int index)
	{
	}

	private float CalculateElementPosition(int index)
	{
		return 0f;
	}

	private int CalculateNewSelectedItem()
	{
		return 0;
	}

	protected override void StartPlaying()
	{
	}

	private void PrepareForSpawnRoleActivating()
	{
	}

	private List<ISpawnRolePreviewObject> GetSortedList(List<ISpawnRolePreviewObject> unsortedList)
	{
		return null;
	}

	private List<MVWorldObjectClient> GetSortedWorldObjectList(List<MVWorldObjectClient> wos, List<ISpawnRolePreviewObject> unsortedList)
	{
		return null;
	}

	private void HandleTeamSwitching(int spawnRoleId)
	{
	}

	private void ShowTierPurchase()
	{
	}

	private void ShowLockedTierPurchase()
	{
	}

	private void ShowTestTier()
	{
	}

	private void OnPurchaseGamePassTier()
	{
	}

	private void OnPlayerPlanetDataUpdated()
	{
	}

	private void AwaitSpawnThenClose()
	{
	}

	private void Close(int spawnRoleID = 0)
	{
	}
}
