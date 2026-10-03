using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;
using UnityEngine.Events;

public class MVWorldObjectClient : MVWorldObject
{
	public new delegate void CallBackDelegate(MVWorldObjectClient woc);

	private struct TransformData
	{
		public Vector3 position;

		public Quaternion rotation;
	}

	public UnityAction<MVWorldObjectClient, PositionChangedEventArgs> PositionChanged;

	public UnityAction<MVWorldObjectClient, RotationChangedEventArgs> RotationChanged;

	public UnityAction<MVWorldObjectClient, ScaleChangedEventArgs> ScaleChanged;

	public UnityAction<MVWorldObjectClient, SelectedEventArgs> SelectedChanged;

	protected bool isCastingShadows;

	protected static int woShadowCastersCount;

	protected static int woMaxShadowCasters;

	private int goId;

	protected string name;

	protected GameObject gameObject;

	protected Collider collider;

	protected Transform transform;

	protected InteractionDataHandlerBase interactionDataHandlerBase;

	protected ObjectPrefab component;

	private MVGroup group;

	private bool selected;

	protected SelectedConnector selectedConnector;

	protected GameObject inputConnectorObject;

	protected GameObject outputConnectorObject;

	protected GameObject objectConnectorObject;

	protected InteractionFlags interactionFlags;

	protected InteractionFlags eliteRequiredFlags;

	protected LayerFlags previewLayerMask;

	private MVRuntimeDataVariables runtimeDataVariables;

	private bool initializedFromInventory;

	public override Vector3 Position
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public override Quaternion Rotation
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Vector3 EulerAngles
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public override Vector3 Scale
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public new virtual Vector3 WorldPosition
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public new Quaternion WorldRotation
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Vector3 WorldEulerAngles
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public virtual Vector3 SyncPos
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public virtual Quaternion SyncRot
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public MVGroup Group
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool Selected
	{
		get
		{
			return false;
		}
		protected set
		{
		}
	}

	public HashSet<int> WorldIDsRecursive => null;

	public virtual Vector3 WorldPivot => default;

	public override bool HasInputConnector => false;

	public override bool HasOutputConnector => false;

	public override bool HasObjectConnector => false;

	public InteractionFlags InteractionFlags
	{
		get
		{
			return InteractionFlags.None;
		}
		set
		{
		}
	}

	public LayerFlags PreviewLayerMask => (LayerFlags)0;

	public PlayInteractionType PlayInteractionType { get; set; }

	public int GameObjectID => 0;

	public GameObject GameObject => null;

	public ObjectPrefab Component => null;

	public Collider Collider => null;

	public Transform Transform => null;

	public InteractionDataHandlerBase InteractionDataHandlerBase => null;

	public SelectedConnector SelectedConnector => SelectedConnector.None;

	public virtual Vector3 InputConnectorOffset => default;

	public virtual Vector3 OutputConnectorOffset => default;

	public virtual Vector3 ObjectConnectorOffset => default;

	public virtual Quaternion InputConnectorRotation => default;

	public virtual Quaternion OutputConnectorRotation => default;

	public virtual Quaternion ObjectConnectorRotation => default;

	public MVRuntimeDataVariables RuntimeDataVariables => null;

	public override Dictionary<object, object> RunTimeData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual MVWorldObjectDocumentationType DocumentationType
	{
		get
		{
			return MVWorldObjectDocumentationType.Missing;
		}
		private set
		{
		}
	}

	public virtual bool Visible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual void PositionChangedNotify()
	{
	}

	public MVWorldObjectClient(Dictionary<object, object> data, GameObject prefabObject, Dictionary<int, MVWorldObjectClient> worldObjects)
	{
	}

	public MVWorldObjectClient(Dictionary<object, object> data, ObjectPrefab prefabObject, Dictionary<int, MVWorldObjectClient> worldObjects)
	{
	}

	private GameObject InstantiatePrefab(GameObject prefabObject, TransformData transformData)
	{
		return null;
	}

	private ObjectPrefab InstantiatePrefab(ObjectPrefab prefabObject, TransformData transformData)
	{
		return null;
	}

	public MVWorldObjectClient(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
	{
	}

	public bool HasInteractionFlag(InteractionFlags flag)
	{
		return false;
	}

	public bool HasEliteRequiredFlag(InteractionFlags flag)
	{
		return false;
	}

	private void SetupBusinessLogic()
	{
	}

	private TransformData GetTransformData(Dictionary<object, object> data)
	{
		return default;
	}

	private void ApplyData(Dictionary<object, object> data)
	{
	}

	private void CreateWorldObject(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
	{
	}

	public MVWorldObjectClient GetHitInteractionHandlingWO()
	{
		return null;
	}

	public virtual void TraverseRecursiveTail(CallBackDelegate callBack)
	{
	}

	public virtual bool CompareWithKoGaMaPackage(MVWorldObjectClient wo, KoGaMaPackageClient koGaMaPackageClient, ref int insertedByProfileId)
	{
		return false;
	}

	public virtual void Compare(MVWorldObjectClient wo, bool visibleCubesOnly, ref int matchingCubeCount, ref int investigatedCubeCount)
	{
	}

	public virtual MVWorldObjectClient Clone(int ownerActorNumber, int cloneGroupId, CloneBookkeeping cloneBookkeeping, Dictionary<int, MVWorldObjectClient> worldObjects, Dictionary<int, RuntimePrototypeCubeModel> prototypes)
	{
		return null;
	}

	public virtual void SetWorldObjectToPurchased()
	{
	}

	public void SetNetworkObject(bool local)
	{
	}

	public virtual void Initialize()
	{
	}

	public void InventoryInitialize()
	{
	}

	public virtual void InitializeInventory()
	{
	}

	public virtual void PlayModeInitialize()
	{
	}

	public virtual void SetupTierInventory()
	{
	}

	public virtual void UnSetupTierInventory()
	{
	}

	public virtual void Destroy()
	{
	}

	public virtual void OnDataUpdate()
	{
	}

	public virtual void OnRunTimeDataUpdate()
	{
	}

	public virtual bool OnEnterObject(EditorStateMachine e)
	{
		return false;
	}

	public virtual bool OnExitObject(EditorStateMachine e)
	{
		return false;
	}

	protected virtual void OnSelectedChanged(bool selected)
	{
	}

	public virtual bool ValidateObjectLinkTarget(MVWorldObjectClient wo)
	{
		return false;
	}

	public void SendPackage(Dictionary<object, object> package)
	{
	}

	public virtual void ReceivePackage(MVPlayer p, Dictionary<object, object> package)
	{
	}

	public virtual void ReceiveInteractionPackage(InteractionData interactionStruct, MVPlayer p)
	{
	}

	private void CreateConnectors()
	{
	}

	public void RuntimeDataUpdate(Dictionary<object, object> dataDelta)
	{
	}

	public override void PartialUpdateWOData(Dictionary<object, object> woData)
	{
	}

	public override void PartialRemoveFromWOData(Dictionary<object, object> entriesToRemove)
	{
	}

	public virtual void HandleInput(NetworkInputActionCodes actionCode, NetworkInputKeyCodes keyCode)
	{
	}

	public virtual Vector3 GetClosestGridPoint(float gridSize, Vector3 position)
	{
		return default;
	}

	public virtual bool OnClickHandler(EditorStateMachine esm, Collider collider)
	{
		return false;
	}

	public Vector3 GetInputConnectorPos()
	{
		return default;
	}

	public Vector3 GetOutputConnectorPos()
	{
		return default;
	}

	public Vector3 GetObjectConnectorPos()
	{
		return default;
	}

	public bool IsPointOverInputConnector(Vector3 mousePoint)
	{
		return false;
	}

	public bool IsPointOverOutputConnector(Vector3 mousePoint)
	{
		return false;
	}

	public virtual void HighlightConnector(bool state)
	{
	}

	private bool DoesScreenPointHitCollider(Vector3 point, Collider collider)
	{
		return false;
	}

	public virtual Bounds GetLocalBounds(BoundsContext boundsContext)
	{
		return default;
	}

	public Vector3[] GetBoundsCornersLocal(BoundsContext boundsContext)
	{
		return null;
	}

	public Vector3[] GetBoundsCornersWorld(BoundsContext boundsContext)
	{
		return null;
	}

	public virtual void Select()
	{
	}

	public virtual void Select(Color color)
	{
	}

	public virtual void DeSelect()
	{
	}

	public virtual void AddPreviewBox()
	{
	}

	public virtual void AddSelectionBox()
	{
	}

	protected GameObject CreateBox(string name, float scale)
	{
		return null;
	}

	public virtual void RemoveSelectionBox()
	{
	}

	public virtual void RemovePreviewBox()
	{
	}

	protected virtual void HideConnectors()
	{
	}

	protected virtual void ShowConnectors()
	{
	}

	public virtual bool Delete(MVWorldObjectClientManager worldObjectClientManager, ref string errorText)
	{
		return false;
	}

	public void SetName()
	{
	}

	public override string ToString()
	{
		return null;
	}

	public virtual Vector3 GetTargetPosition()
	{
		return default;
	}

	public float ComputeObjectRadius()
	{
		return 0f;
	}

	public float ComputeObjectSqrRadius()
	{
		return 0f;
	}

	public void RotateAround(Vector3 pivot, Vector3 axis, float angle)
	{
	}

	public void RotateAroundLocal(Vector3 pivot, RotationMode rotationMode, float angle)
	{
	}

	private Vector3 GetLocalAxis(RotationMode rotationMode)
	{
		return default;
	}

	public void ResetRotation()
	{
	}

	public static void DestroyRecursive(MVWorldObjectClient wo)
	{
	}

	public virtual void DrawTransformGizmo()
	{
	}

	public virtual void OnContextMenu()
	{
	}
}
