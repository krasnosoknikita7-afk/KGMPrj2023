using System.Collections.Generic;
using MV.Common;
using UnityEngine;

public class MVBody : MVBlueprintBase, IWorldObjectWithModelingConstraint
{
	private BodyAccessoriesController bodyAccessoriesController;

	private BodyAccessoriesController previewBodyAccessoriesController;

	private bool collidersEnabled;

	private bool shadowVisible;

	private bool visible;

	private bool forceHidden;

	private MVBodyObject bodyObject;

	private Dictionary<int, IModelingConstraint> constraints;

	private List<Renderer> renderers;

	private List<Collider> colliders;

	private List<MVCubeModelInstance> attachedPartModels;

	private bool initialized;

	private bool hasAvatarBeenAttached;

	private Vector3 modelScale;

	private BodyClone bodyClone;

	public string LayerToSetTo { private get; set; }

	public BoneAnimation Animation => null;

	public bool IsPlayerBody => false;

	public BodyData BodyData => null;

	public List<MVCubeModelInstance> AttachedParts => null;

	public AvatarBlobShadowController BlobShadow => null;

	public new bool Visible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ForceHidden
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ShadowVisible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private bool CollidersEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool AccessoryMoveOverride
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsAccessorySlotOccupied(AccessorySlotType accessorySlotType)
	{
		return false;
	}

	public float GetAccessoryOffset(AccessorySlotType slot)
	{
		return 0f;
	}

	public void ApplyAccessoryOffset(float yOffset, AccessorySlotType slot)
	{
	}

	public float GetAccessoryScale(AccessorySlotType slot)
	{
		return 0f;
	}

	public void ApplyAccessorySize(float size, AccessorySlotType slot)
	{
	}

	public bool IsAccessoryEquipped(int streamingAssetId)
	{
		return false;
	}

	public GameObject CreateClone(bool enableAllRenderers = false, bool hideEquippedItem = false)
	{
		return null;
	}

	public void DestroyClone()
	{
	}

	public MVBody(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null)
	{
	}

	public void PreviewAccessory(AccessoryDataClient viewItem)
	{
	}

	public void EndPreviewAccessory()
	{
	}

	private void UpdateBodyClone(Dictionary<object, object> accessoryData)
	{
	}

	public void SyncOffset(AccessorySlotType slot, float offset)
	{
	}

	public void SyncScale(AccessorySlotType slot, float scale)
	{
	}

	public override void Initialize()
	{
	}

	public void InitializeHealth(float currentHealthAmount)
	{
	}

	public void InitializeShield(float currentShieldAmount)
	{
	}

	public void UpdateBlinking()
	{
	}

	public override void InitializeInventory()
	{
	}

	public override void Destroy()
	{
	}

	public void Attach(MVAvatar mvAvatar, bool isLocal)
	{
	}

	public void Detach()
	{
	}

	public void StartBlinking(BlinkType type, float duration)
	{
	}

	public void StopBlinking(BlinkType type)
	{
	}

	public void ToggleBlinking(bool shouldShowBlinking)
	{
	}

	public GameObject CopyByValue()
	{
		return null;
	}

	private void CopyMaterialsByValue(GameObject bodyCloneGO)
	{
	}

	private void InitializeCommon()
	{
	}

	private void RefreshAccessories()
	{
	}

	private Dictionary<object, object> GetAccessoryData()
	{
		return null;
	}

	private void UpdateVisibility()
	{
	}

	public override Bounds GetLocalBounds(BoundsContext boundsContext)
	{
		return default;
	}

	public override MVWorldObjectClient Clone(int ownerActorNumber, int cloneGroupId, CloneBookkeeping cloneBookkeeping, Dictionary<int, MVWorldObjectClient> worldObjects, Dictionary<int, RuntimePrototypeCubeModel> prototypes)
	{
		return null;
	}

	public IModelingConstraint GetModelConstaint(MVCubeModelInstance cubeModel)
	{
		return null;
	}

	public override void OnDataUpdate()
	{
	}

	public void OnAnimationUpdate(object newAnimationData)
	{
	}

	public void OnHealthUpdate(object newHealthData)
	{
	}

	public void OnShieldUpdate(object newShieldData)
	{
	}

	public void EnableBodyBlinker()
	{
	}

	public void DisableBodyBlinker()
	{
	}

	public void StartAnimation(string newAnimation)
	{
	}

	public MVCubeModelInstance GetBodyPart(string part)
	{
		return null;
	}

	private void AttachCubes()
	{
	}

	private void AttachCube(string boneName)
	{
	}

	private void AlignModel(string boneName, Transform bone, GameObject model)
	{
	}
}
