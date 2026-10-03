using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public class MVGamePointChest : MVGamePointRewardLogicObject
{
	public enum GamePointChestClientState
	{
		Closed = 0,
		Opening = 1,
		Open = 2
	}

	private static readonly UseGUIResult purchaseOptions;

	private bool canRespawn;

	private int respawnTime;

	private float pickUpTime;

	private const string respawnString = "respawnTime";

	private const string gamePointAwardedString = "gamePointAmount";

	private GamePointChestClientState state;

	private UseInteractor useInteractor;

	private MVGamePointChestObject chestObject;

	private const int gamePointAmountSettingDefaultValue = 30;

	private int gamePointsRewarded;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public override bool HasInputConnector => false;

	public override bool HasOutputConnector => false;

	protected override bool HasVisualsInPlaymode => false;

	public override bool Visible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public MVGamePointChest(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	private void SetupUseInteractor()
	{
	}

	private void UpdateGamePointsRewardedAmount()
	{
	}

	private void UpdateChestSize()
	{
	}

	private void UpdateCanRespawn(Dictionary<object, object> newData)
	{
	}

	private bool HandleDifferentChestSizeStages(float percentage)
	{
		return false;
	}

	public override void OnDataUpdate()
	{
	}

	public override void InitializeInventory()
	{
	}

	protected override void OnUpdate()
	{
	}

	public bool IsUsable(int id, MVInteractableBase avatarInteractable)
	{
		return false;
	}

	private bool OpenChest(int instigatorID)
	{
		return false;
	}

	private void triggerBoxEvents_TriggerEnter(object sender, TriggerEventArgs e)
	{
	}

	public override void Reset()
	{
	}

	private void OnWinningConditionFulfilled(IWinningCondition winningCondition)
	{
	}

	private void SetToClosed()
	{
	}

	private void HandleStandaloneDisabling()
	{
	}

	private void Disable()
	{
	}

	public override MVWorldObjectClient Clone(int ownerActorNumber, int cloneGroupId, CloneBookkeeping cloneBookkeeping, Dictionary<int, MVWorldObjectClient> worldObjects, Dictionary<int, RuntimePrototypeCubeModel> prototypes)
	{
		return null;
	}

	public override MVWorldObject DeepCopy()
	{
		return null;
	}

	public override void Destroy()
	{
	}

	public override Vector3 GetClosestGridPoint(float gridSize, Vector3 position)
	{
		return default;
	}

	public override Bounds GetLocalBounds(BoundsContext boundsContext)
	{
		return default;
	}
}
