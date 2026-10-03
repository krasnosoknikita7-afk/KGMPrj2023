using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.AdIntegration;
using CodeStage.AntiCheat.ObscuredTypes;
using ExitGames.Client.Photon;
using MV.Common;
using MV.WorldObject;
using MV.WorldObject.MetaData;
using MV.WorldObject.RuntimeEvents;
using UnityEngine;
using UnityEngine.Events;

public class MVNetworkGame : IPhotonPeerListener
{
	public delegate void OnReceivedChatMessageDelegate(MVPlayer sender, string message);

	public delegate void OnMarketPlaceActionCompleteDelegate(bool success);

	private class EventHandling
	{
		private class DynamicEventCallbackManager
		{
			private class EventCallback
			{
				[CompilerGenerated]
				private Action<EventData> m_OnEventData;

				public event Action<EventData> OnEventData
				{
					[CompilerGenerated]
					add
					{
					}
					[CompilerGenerated]
					remove
					{
					}
				}

				public void Notify(EventData eventData)
				{
				}

				public void Subscribe(Action<EventData> callback)
				{
				}

				public bool UnSubscribe(Action<EventData> callback)
				{
					return false;
				}
			}

			private Dictionary<MVEventCodes, EventCallback> eventCallbacks;

			private readonly HashSet<MVEventCodes> eventsHandledByDynamicEventCallbackManager;

			public bool IsDynamicEvent(MVEventCodes eventCode)
			{
				return false;
			}

			public void Notify(MVEventCodes eventCode, EventData eventData)
			{
			}

			public void SubscribeToEvent(MVEventCodes eventCode, Action<EventData> callback)
			{
			}

			public void UnSubscribeToEvent(MVEventCodes eventCode, Action<EventData> callback)
			{
			}
		}

		private DynamicEventCallbackManager dynamicEventCallbackManager;

		private bool cacheEvents;

		private Queue<EventData> cachedEvents;

		private MVNetworkGame networkGame;

		private const float maxJoinTimeValue = 250000f;

		public bool CacheEvents
		{
			set
			{
			}
		}

		public EventHandling(MVNetworkGame networkGame)
		{
		}

		public void UncacheEventsFromJoin()
		{
		}

		public void OnEvent(EventData photonEvent)
		{
		}

		private void HandleEvent(MVEventCodes eventCode, EventData photonEvent)
		{
		}

		public void SubscribeToEvent(MVEventCodes eventCode, Action<EventData> callback)
		{
		}

		public void UnSubscribeToEvent(MVEventCodes eventCode, Action<EventData> callback)
		{
		}

		private void HandleActorReadyMetric()
		{
		}
	}

	private class GameDataQueryManager
	{
		public class GameDataQuery
		{
			private BytePacker bp;

			private int instigatorActorNumber;

			public QueryType QueryType { get; private set; }

			public int InstigatorActorNumber => 0;

			public override string ToString()
			{
				return null;
			}

			public GameDataQuery(BytePacker bp, int instigatorActorNumber, QueryType queryType)
			{
			}

			public void AddGameDataQuery(GameDataQuery gameDataQuery)
			{
			}

			public BytePacker GetBytePacker()
			{
				return null;
			}
		}

		private readonly Dictionary<int, GameDataQuery> gameDataQueries;

		public void HandleDataBatch(int instigator, int queryId, QueryType queryType, bool queryDataLeft, BytePacker bp)
		{
		}

		public void OnGameQueryReady(int queryId)
		{
		}

		private void OnGetGameBatch(int queryId, GameDataQuery gameDataQuery)
		{
		}

		private void InitializeGameQueryData(GameDataQuery gameDataQuery)
		{
		}
	}

	private class LogicEventQueue
	{
		private readonly Dictionary<int, Queue<EventData>> logicEvents;

		public int Count => 0;

		public void Enqueue(EventData eventData)
		{
		}

		public void Dequeue(int timestamp)
		{
		}

		private void HandleEvent(EventData photonEvent)
		{
		}
	}

	private class LogicObjectManagerClientWrapper
	{
		private LogicEventQueue logicEventQueue;

		private readonly MVNetworkGame networkGame;

		private UpdateEvaluator updateEvaluatorStep;

		private UpdateEvaluator fastFordwardUpdateEvaluator;

		public int StepTimeStamp => 0;

		public LogicObjectManagerClientWrapper(MVNetworkGame networkGame, int stepTimestamp)
		{
		}

		public void EnqueueLogicEvent(EventData eventData)
		{
		}

		public void Step()
		{
		}

		public void FastForward(int timestamp)
		{
		}

		public void FastForwardImmediately(int timestamp)
		{
		}

		public void Reset()
		{
		}

		public void Update()
		{
		}

		private void ExecuteRemainingFrames()
		{
		}

		private void UpdateLogicObjectManager()
		{
		}
	}

	private class UpdateEvaluator
	{
		private int lastUpdateTick;

		private int accumulatedTime;

		private int stepTimestamp;

		private readonly int updateInterval;

		public int StepTimestamp
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int UpdateInterval => 0;

		public UpdateEvaluator(int updateInterval)
		{
		}

		public bool DoUpdate(LogicObjectManager logicObjectManager)
		{
			return false;
		}
	}

	public class OperationRequests
	{
		private OperationResponsePendingManager operationResponsePendingManager;

		private MVNetworkGame networkGame;

		private PhotonPeer peer;

		public string dummyData;

		private bool gamepointWelcomeClaimed;

		public OperationRequests(MVNetworkGame networkGame)
		{
		}

		public void UploadData(int id, byte[] uploadData)
		{
		}

		public void TryRemovePendingOperation(MVOperationCodes operationCode)
		{
		}

		public void Syncronize()
		{
		}

		public void ClaimRewardedAdXP(bool success)
		{
		}

		public void SyncronizePing()
		{
		}

		public void SetSpawnRoleBody(int avatarCreatorWoId, int avatarBodyDbId)
		{
		}

		public void TogglePreviewTier()
		{
		}

		public void IncrementStatRequest(IncrementStatRequestType statRequestType, int value = 0)
		{
		}

		public void ClaimPlayingNewGameRewardedGold()
		{
		}

		public void GetHighScoreList()
		{
		}

		public void GetTopHighScoreList()
		{
		}

		public void CustomDevCommands()
		{
		}

		public void GetAvatarBodies()
		{
		}

		public void CreateSpawnRole(int avatarSpawnerWoId)
		{
		}

		public void ClaimGamePointWelcomeReward()
		{
		}

		public void AddObjectLink(ObjectLink link)
		{
		}

		public void PublishPlanet(Action<string> errorHandler)
		{
		}

		private bool PublishPlanet(bool newImagePending, Action<string> errorHandler)
		{
			return false;
		}

		public void UploadGameScreenShot()
		{
		}

		private void HandleUploadScreenShotData(byte[] screenshot)
		{
		}

		public bool IsOperationPending(MVOperationCodes operationCode)
		{
			return false;
		}

		public void RequestAcceptFriendShip(int friendID)
		{
		}

		public void ResetPlayerPlanetData()
		{
		}

		public void RequestRejectFriendShip(int friendID)
		{
		}

		public void StartSessionTime()
		{
		}

		public void RequestWoUniquePrototype(int woId)
		{
		}

		public void Handshake()
		{
		}

		public void JoinGame(string encrypt)
		{
		}

		public bool AddLink(Link link)
		{
			return false;
		}

		public void UpdateWorldObject(int id, Vector3 position, byte[] rotation, TransformPackageType packageType)
		{
		}

		public void UpdateLineOfFire(int worldObjectIDPickupOwner, Vector3 camDir, Vector3 camOrigin)
		{
		}

		public void TransferWorldObjectsToGroup(int groupId, int[] worldObjects)
		{
		}

		public void TransferOwnership(int worldObjectID, int ownerActorNr, Transform t)
		{
		}

		public void PostGameMsg(MVGameMsgType gameMsgType, Dictionary<object, object> gameMsgData)
		{
		}

		public void PostChatMsg(Dictionary<object, object> gameMsgData, MVGameMsgType chatMsgType)
		{
		}

		public void PostNotificationOperation(NotificationType type, Dictionary<object, object> notificationData)
		{
		}

		public void LockHierarchy(int worldObjectID, bool lockHierarchy)
		{
		}

		public void UpdateWorldObjectDataPartial(int worldObjectID, string keyPath, object value)
		{
		}

		public void UpdateWorldObjectDataPartial(int worldObjectID, Dictionary<object, object> woData)
		{
		}

		public void RemoveWorldObjectDataPartial(int worldObjectID, string keyPath)
		{
		}

		public void RemoveWorldObjectDataPartial(int worldObjectID, Dictionary<object, object> woDataToRemove)
		{
		}

		public void WorldObjectRPC(int worldObjectID, Dictionary<object, object> dataPackage)
		{
		}

		public void UpdateWorldObjectRunTimeData(int worldObjectID, Dictionary<object, object> worldObjectRunTimeData)
		{
		}

		public void RegisterWorldObject(WorldObjectType type, int groupId, Dictionary<object, object> woData, Vector3 position, Quaternion rotation, Vector3 scale, bool localOwner, bool transferOwnershipToServerOnLeave)
		{
		}

		public void RequestBuiltInItem(BuiltInItem builtInItem, int groupId, Dictionary<object, object> customData, Vector3 position, Quaternion rotation, Vector3 scale, bool localOwner, bool transferOwnershipToServerOnLeave)
		{
		}

		public void AddItemToWorld(int itemId, int groupId, Vector3 position, Quaternion rotation, bool localOwner, bool transferOwnershipToServerOnLeave, bool isPreviewItem)
		{
		}

		public void CloneWorldObjectTree(MVWorldObjectClient root, bool localOwner, bool setAsPreviewItem, bool cloneToRootGroup)
		{
		}

		public void CloneWorldObjectTreeWithPosition(MVWorldObjectClient root, Vector3 position, Quaternion rotation, bool localOwner, bool setAsPreviewItem, bool cloneToRootGroup, bool isTempObject)
		{
		}

		public void CloneTempWorldObjectWithOriginalReference(MVWorldObjectClient root, Vector3 position, Quaternion rotation)
		{
		}

		private Dictionary<byte, object> CreateBasicCloneData(MVWorldObjectClient root, bool localOwner, bool setAsPreviewItem, bool cloneToRootGroup)
		{
			return null;
		}

		private Dictionary<byte, object> CreateWithPositionCloneData(MVWorldObjectClient root, Vector3 position, Quaternion rotation, bool localOwner, bool setAsPreviewItem, bool cloneToRootGroup, bool isTempObject)
		{
			return null;
		}

		public void AddPlanetToPlanet(int planetId, int subtreeId)
		{
		}

		public void UnregisterWorldObject(int worldObjectID)
		{
		}

		public void LocalPlayerLevelChanged(int level)
		{
		}

		public void JoinNotification()
		{
		}

		public void Ban(CheatType cheatType)
		{
		}

		public void AutoRegisterLocalPrototype(int woId, int worldInventoryID)
		{
		}

		public void UpdatePrototype(int worldInventoryID, byte[] prototypeData)
		{
		}

		public void UpdatePrototypeScale(int worldInventoryID, float scale)
		{
		}

		public void AddWorldObjectToInventory(int worldObjectID)
		{
		}

		public void RemoveItemFromInventory(int itemID)
		{
		}

		public void UpdateInventorySlots(Dictionary<object, object> itemIdToSlotIndexTable)
		{
		}

		public void SendClientLog(string logString, string stackTrace, LogType type, Dictionary<string, object> extraSentryData, Dictionary<string, string> tags)
		{
		}

		public void ReportCaptureFlag(int woid)
		{
		}

		public void ReportReachedTimeAttackFlag(int captureTime, int woid)
		{
		}

		public void ResetLogicChunk(int worldObjectID)
		{
		}

		public bool RequestFriendShipByID(int id, ref string errorText)
		{
			return false;
		}

		public void RequestMarketPlaceItem(int itemID)
		{
		}

		public void RequestAddItemToMarketPlace(int itemID, string itemName, string itemDescription)
		{
		}

		public void RequestRemoveItemFromMarketPlace(int itemID)
		{
		}

		public void RequestLargeDBQuery(MVOperationCodes operationCode, DBQuery query, Dictionary<object, object> inData, int numRowsPerReturn)
		{
		}

		public void RequestResetTerrain()
		{
		}

		public void SendRuntimeEventOperation(RuntimeEvent runtimeEvent)
		{
		}

		public void SetTeam(MVTeam team)
		{
		}

		public void AttachWorldObjectToSeat(int seatOwnerWoID, int worldObjectID, VehicleSeatBase seatBase)
		{
		}

		public void AddAvatarToAvatarShopInventory(int worldObjectId, string name)
		{
		}

		public void DeleteAvatarFromShopInventory(int worldObjectId)
		{
		}

		public void SpawnVehicleWithDriver(int worldObjectSpawnerVehicleID, int worldObjectID, VehicleSeatBase seatBase)
		{
		}

		public void VehicleEnergyUse(int worldObjectSpawnerVehicleEnergyID, int worldObjectID)
		{
		}

		public void DetachWorldObjectFromVehicle(int worldObjectID)
		{
		}

		public void SetAvatarAccessorySlot(int avatarBodyWoID, int streamingAssetId, float offset, float scale)
		{
		}

		public void UnEquipAccessory(int avatarBodyWoID, AccessorySlotType accessorySlotType)
		{
		}

		public void ResetAvatar(int AvatarID)
		{
		}

		public void SetActiveAvatar(int AvatarID)
		{
		}

		public void UpdateAvatarAccessoryOffset(int bodyWoID, AccessorySlotType slot, float offset)
		{
		}

		public void UpdateAvatarAccessoryScale(int bodyWoID, AccessorySlotType slot, float scale)
		{
		}

		public void PurchaseSwitchTheme(int themeId, Dictionary<object, object> themeSettingsData)
		{
		}

		public void UnlockMaterial(int materialID)
		{
		}

		public void UnlockClientShopInventoryItem(int itemId)
		{
		}

		public void PurchaseAvatar(int avatarId)
		{
		}

		public void RemoveLink(int linkID)
		{
		}

		public void RemoveObjectLink(int objectLinkID)
		{
		}

		public void TriggerBoxEnter(int triggerBoxOwnerId, int triggerInstigatorId)
		{
		}

		public void TriggerBoxExit(int triggerBoxOwnerId, int triggerInstigatorId)
		{
		}

		public bool UploadScreenshot(ImageType imageType)
		{
			return false;
		}

		public void PurchaseAvatarAccessory(int streamingAssetID)
		{
		}

		public void PurchaseTier(GamePassTier gamePassTier)
		{
		}

		public void PurchaseGameBooster(string gameBooster)
		{
		}

		public void PurchaseAvatarAccessoryBundle(int bundleId)
		{
		}

		public void LogicActivateRequest(int woID, bool activate)
		{
		}

		public void SetFirstTimeEvent(FirstTimeEvent firstTimeEvent)
		{
		}

		public void SetTier(GamePassTier gamePassTier)
		{
		}

		public void SetGamePassTierToSeenOperation(GamePassTier gamePassTier)
		{
		}

		public void SetHighlightToSeen(int highlightId)
		{
		}

		public void OverrideFirstTimeEvent(FirstTimeEvent firstTimeEvent, bool overrideValue)
		{
		}

		public void ResetFirstTimeEvents(bool overrideValue)
		{
		}

		public void SetMouseSensitivity(float newMouseSensitivity)
		{
		}

		public void GetResetAvatar(int avatarWoID)
		{
		}

		public void RevokeEditRights(MVPlayer target)
		{
		}

		public void Kick(MVPlayer target, string reason)
		{
		}

		public void Observe(bool observe = true)
		{
		}

		private void AdminOperation(byte adminOperationType, int amount, int profileId, string msg)
		{
		}

		public void ShutdownSession()
		{
		}

		public void Ban(int hours, MVPlayer target, string reason)
		{
		}

		public void Expel(MVPlayer target, string reason)
		{
		}

		public void SetSayChatBubbleVisible(bool shouldShow)
		{
		}

		public void GetThemesData()
		{
		}

		public void ResetHighlights()
		{
		}

		public void RequestAccessoryData()
		{
		}

		public void SetEarningsReportToSeenOperation()
		{
		}

		public void SetActiveSpawnRole(int woID)
		{
		}

		public void RequestUpdateGoldResponse()
		{
		}

		private void PurchaseProduct(MVProductType productTypeID, Dictionary<object, object> productData)
		{
		}

		public void ChangeMaterial(ObscuredByte currentMaterialId)
		{
		}

		public void GetInventoryItemData(int itemID)
		{
		}

		public void AdAction(AdType adType, AdActionType actionType, AdContext adContext = AdContext.None)
		{
		}
	}

	private class OperationResponseHandling
	{
		private MVNetworkGame networkGame;

		public OperationResponseHandling(MVNetworkGame networkGame)
		{
		}

		public void HandleOperationResponse(OperationResponse operationResponse)
		{
		}

		private void ExecuteOperationResponse(MVOperationCodes opCode, Dictionary<byte, object> returnValues, short returnCode)
		{
		}
	}

	private class ReconnectWithAlternatePortHandler
	{
		private const int alternateSecureWebSocketPort = 19091;

		private const int alternateWebSocketPort = 19090;

		private const int alternateUDPPort = 27000;

		private bool triedAlternatePort;

		private MVNetworkGame networkGame;

		public ReconnectWithAlternatePortHandler(MVNetworkGame networkGame)
		{
		}

		public bool IsHandling(StatusCode statusCode)
		{
			return false;
		}

		private static int GetAlternatePort(string serverIP)
		{
			return 0;
		}
	}

	private class StatusChangedHandling
	{
		private ReconnectWithAlternatePortHandler reconnectWithAlternatePortHandler;

		private bool registeredFatalStatusCodeInStatHat;

		private MVNetworkGame networkGame;

		public StatusChangedHandling(MVNetworkGame networkGame)
		{
		}

		private void HandleDisconnectMetric(StatusCode returnCode)
		{
		}

		public void OnStatusChanged(StatusCode returnCode)
		{
		}
	}

	[CompilerGenerated]
	private EventHandler<ReceivedItemFromQueryEventArgs> m_ReceivedItemFromQuery;

	[CompilerGenerated]
	private EventHandler<ReceivedItemFromQueryEventArgs> m_ReceivedAvatarBodiesFromQuery;

	[CompilerGenerated]
	private Action<string> m_ReceivedAccessoryData;

	private MVConnState connState;

	private const string appName = "MVGameServer";

	private MVItemBusinessLogic itemBusinessLogic;

	private bool isPublished;

	private GameDataQueryManager gameDataQueryManager;

	private TransformNetworkManager transformNetworkManager;

	public readonly GameEventManager GameEventManager;

	private readonly Dictionary<Region, float> timeZoneMap;

	private int lastFrameServerTimeUpdate;

	private int lastFrameLocalTimeUpdate;

	private int serverTimeInMilliseconds;

	private int localTimeInMilliseconds;

	private MVTeamManager teamManager;

	private GameStatCounterManager gameStatCounterManager;

	private LevelRewardsManager levelRewardsManager;

	private WorldNetwork worldNetwork;

	public Action<int, Dictionary<object, object>> PurchaseProductResponseHandler;

	public Action<IWinningCondition> OnWinningConditionFulfilled;

	public Action<int> OnActiveAvatar;

	public Action<bool> OnItemAddedToWorld;

	public UnityAction<string> OnPublishedPlanet;

	public UnityAction<string> OnAddWorldObjectToInventoryCallbackDev;

	public Action<bool> OnSetAvatarAccessoryResponse;

	public OnReceivedChatMessageDelegate OnReceivedChatMessage;

	public OnMarketPlaceActionCompleteDelegate OnMarketPlaceActionComplete;

	[CompilerGenerated]
	private EventHandler<ScreenshotUploadedEventArgs> m_ScreenshotUploaded;

	public Action OnActiveAvatarSet;

	public Action OnAccessoryUnequipped;

	private readonly MVPlayerContainer playerContainer;

	private PhotonLoggingConfig photonLoggingConfig;

	private EmbeddedSiteConfigData embeddedSiteConfigData;

	private LogicObjectManagerClientWrapper logicObjectManagerClientWrapper;

	private RuntimeVariableNetworkManager runtimeVariableNetworkManager;

	private float prevServiceCallTime;

	private const float serviceCallInterval = 0.07f;

	private GameDataQueryManager.GameDataQuery gameDataQuery;

	private EventHandling eventHandling;

	private OperationRequests operationRequests;

	private OperationResponseHandling operationResponseHandling;

	private StatusChangedHandling statusChangedHandling;

	public LogicObjectManagerClient LogicObjectManager { get; private set; }

	public MVGameType GameType { get; private set; }

	public Region Region { get; private set; }

	public float TimeZone => 0f;

	public MVItemBusinessLogic ItemBusinessLogic => null;

	public MVGameCoinManager GameCoinManager { get; private set; }

	public ItemCategories ItemCategories { get; private set; }

	public MVConnState ConnState
	{
		get
		{
			return MVConnState.Disconnected;
		}
		set
		{
		}
	}

	public bool IsPlaying => false;

	public MVNetworkGameStateListener NetworkGameStateListener { get; private set; }

	public PhotonPeer Peer { get; private set; }

	public ObscuredString XpKey { get; private set; }

	public int MarketPlaceLevel { get; private set; }

	public int PublishLevel { get; private set; }

	public string AdConsentEndpointURL { get; private set; }

	public string KogamaMainpageURL { get; private set; }

	public CreySettings CreySettings { get; private set; }

	public CustomTouristPromotionSettings CustomTouristPromotionSettings { get; private set; }

	public ElitePromotionSettings EliteSettings { get; private set; }

	public int ServerTimeInMilliSeconds => 0;

	public int LocalTimeInMilliSeconds => 0;

	public int StepTimeStamp => 0;

	public MVMaterialRepository MaterialRepository { get; private set; }

	public PlayerRepository PlayerRepository { get; private set; }

	public ShopRepository ShopRepository { get; private set; }

	public GameTierShopRepository GameTierShopRepository { get; private set; }

	public AvatarRepository AvatarShopRepository { get; private set; }

	public MvAvatarMetaDataWoMap AvatarMetaDataWoMap { get; private set; }

	public LevelRewardsManager LevelRewardsManager => null;

	public MVTeamManager TeamManager => null;

	public MVGameModeChangeNotifier GameStateController { get; private set; }

	public FriendList Friends { get; private set; }

	public MVLocalObjectController PlayerController { get; private set; }

	public GameStatCounterManager GameStatCounterManager => null;

	public WinningConditionManager WinningConditionManager { get; private set; }

	public World World => null;

	public MVWorldObjectClientManager WorldObjectClientManager => null;

	public OperationRequests OperationRequestSender => null;

	public TransformNetworkManager TransformNetworkManager => null;

	public MVPlayerContainer MVPlayerContainer => null;

	public MVLocalPlayer LocalPlayer => null;

	public RuntimeVariableNetworkManager RuntimeVariableNetworkManager => null;

	public event EventHandler<ReceivedItemFromQueryEventArgs> ReceivedItemFromQuery
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event EventHandler<ReceivedItemFromQueryEventArgs> ReceivedAvatarBodiesFromQuery
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<string> ReceivedAccessoryData
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event EventHandler<ScreenshotUploadedEventArgs> ScreenshotUploaded
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public MVNetworkGame(PhotonLoggingConfig photonLoggingConfig, EmbeddedSiteConfigData embeddedSiteConfigData)
	{
	}

	public void SubscribeToEvent(MVEventCodes eventCode, Action<EventData> callback)
	{
	}

	public void UnSubscribeToEvent(MVEventCodes eventCode, Action<EventData> callback)
	{
	}

	private void CreatePrivateClasses()
	{
	}

	private void networkGameStateListener_OnGameStateChanged(object sender, GameStateChangeEventArgs e)
	{
	}

	public void Update()
	{
	}

	public void Cleanup()
	{
	}

	private void UpdateGame()
	{
	}

	public void Service()
	{
	}

	public bool Join()
	{
		return false;
	}

	private static void GeneratePlanetScreenShot(Action<byte[]> callback)
	{
	}

	public void OnUnregisterWorldObjectResponse(int worldObjectID)
	{
	}

	public void OnResetLogicChunkEvent(int worldObjectID)
	{
	}

	public void OnPickupItemStateChangeEvent(PickupItemState state, int worldObjectID, int instigatorActorNr)
	{
	}

	public void OnUpdateLineOfFire(int worldObjectID, Vector3 camOrigin, Vector3 camDir)
	{
	}

	public void AllModesSetup(EventData photonEvent)
	{
	}

	public void PlayModeSetup(EventData photonEvent)
	{
	}

	public void BuildModeSetup(EventData photonEvent)
	{
	}

	private void SetupLogicManager(int stepTimestamp)
	{
	}

	public void OnNotificationEventReceived(NotificationType type, Dictionary<object, object> data)
	{
	}

	private void OnRequestFriendshipResponse(int returnCode)
	{
	}

	public void OnPurchaseProductResponse(int returnCode, Dictionary<object, object> purchaseResponseData)
	{
	}

	public void AddCloneToWorldObjects(MVWorldObjectClient wo)
	{
	}

	private Dictionary<byte, object> GetAttachWorldObjectToSeatData(VehicleSeatBase seatBase)
	{
		return null;
	}

	private void OnJoinResponse(Dictionary<byte, object> returnValues)
	{
	}

	private void InitializeManagers()
	{
	}

	private void OnRequestMaterialsResponse(Dictionary<object, object> materialList)
	{
	}

	private void CreatePlayersFromUserList(Dictionary<object, object> userList)
	{
	}

	private void OnGetBuiltInItemBusinessData(Dictionary<object, object> builtInItemBusinessData)
	{
	}

	private void OnRequestFriendsResponse(Dictionary<object, object> friendsList)
	{
	}

	private void WOCM_InitializedGameQueryDataHandler(object sender, InitializedGameQueryDataEventArgs e)
	{
	}

	private void TransferBodyResponseHandler(object sender, OnTransferWosResponseEventArgs e)
	{
	}

	private void OnTransferOwnershipResponse(Dictionary<byte, object> returnValues, int returnCode)
	{
	}

	private void OnLockHierarchyResponse(Dictionary<byte, object> returnValues, int returnCode)
	{
	}

	private void OnRequestWoUniquePrototypeFailed(Dictionary<byte, object> returnValues)
	{
	}

	private void OnLockHierarchyEvent(EventData eventData)
	{
	}

	private void OnUnregisterWorldObjectEvent(int worldObjectID)
	{
	}

	private void OnUpdateWorldObjectEvent(EventData photonEvent)
	{
	}

	private void OnWorldObjectRPCEvent(EventData photonEvent)
	{
	}

	private void OnTransferOwnershipEvent(EventData photonEvent)
	{
	}

	private void OnUnregisterPrototypeEvent(int worldInventoryID)
	{
	}

	private void OnFriendRequestEvent(int friendID, int profileID, int friendProfileID)
	{
	}

	private void OnFriendUpdateEvent(int friendID, int profileID, FriendStatus status)
	{
	}

	private void OnAddLinkEvent(int fromID, int toID, int linkID)
	{
	}

	private void OnRemoveLinkEvent(int linkID)
	{
	}

	private void OnAddObjectLinkEvent(int fromID, int toID, int linkID)
	{
	}

	private void OnRemoveObjectLinkEvent(int linkID)
	{
	}

	private void OnTriggerBoxEnterEvent(int actorNr, int worldObjectID)
	{
	}

	private void OnTriggerBoxExitEvent(int actorNr, int worldObjectID)
	{
	}

	private void OnTriggerBoxStayBegin(int worldObjectID, int instigatorId)
	{
	}

	private void OnTriggerBoxStayEnd(int worldObjectID)
	{
	}

	private void OnRemoveItemFromInventory(int itemID)
	{
	}

	private void OnWoUniquePrototypeEvent(int woId, int worldInventoryId)
	{
	}

	public void ResetPlayer()
	{
	}

	public void OnSetWorldObjectsToPurchasedEvent(int purchaseProfileId, int itemId)
	{
	}

	public void OnTransferWorldObjectsToGroup(EventData eventData)
	{
	}

	public MVWorldObjectClient OnCloneWorldObjectTree(EventData eventData)
	{
		return null;
	}

	public MVWorldObjectClient OnCloneWorldObjectTreePosition(EventData eventData)
	{
		return null;
	}

	public void OnCloneTempWorldObjectWithOriginalReferenceEvent(EventData eventData)
	{
	}

	public void OnGetGameBatch(EventData eventData)
	{
	}

	private void OnGameQueryReady(EventData eventData)
	{
	}

	private void OnPostWinnerReportEvent()
	{
	}

	private void OnCollectiblePickedUp(EventData photonEvent)
	{
	}

	private void OnGetActiveAvatarResponse(int woid)
	{
	}

	public void OnSetTeamEvent(int actorNr, MVTeam team)
	{
	}

	public void OnGetItemCategories(Dictionary<object, object> outData)
	{
	}

	public void OnGetPlanetOwnershipTypes(Dictionary<object, object> outData)
	{
	}

	private void OnInventoryResultSetResponse(Dictionary<object, object> outData)
	{
	}

	private void OnShopInventoryResultSetResponse(Dictionary<object, object> outData, bool isDone)
	{
	}

	private void OnAvatarShopInventoryResultSetResponse(Dictionary<object, object> outData)
	{
	}

	public void OnAddItemToInventory(Dictionary<byte, object> returnValues, short returnCode)
	{
	}

	public void OnAddWorldObjectToInventoryResponseDev(int returnCode, int worldObjectID, int itemID)
	{
	}

	public void OnOperationResponse(OperationResponse operationResponse)
	{
	}

	public void OnStatusChanged(StatusCode statusCode)
	{
	}

	public void OnEvent(EventData eventData)
	{
	}

	private void HandleGameSnapshotData(BytePacker bytePacker, QueryType queryType, bool dataLeft)
	{
	}

	private void CreateGame()
	{
	}

	private void OnGameCreated(object sender, InitializedGameQueryDataEventArgs initializedGameQueryDataEventArgs)
	{
	}

	private void OnLevelChanged(int actorNr, int level)
	{
	}

	private void OnSetSayChatBubbleVisible(int actorNr, bool visible)
	{
	}

	private void LoadModeGui()
	{
	}

	public void DebugReturn(DebugLevel level, string debug)
	{
	}
}
