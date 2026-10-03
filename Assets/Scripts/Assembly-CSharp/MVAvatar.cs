using System.Collections.Generic;
using MV.Common;
using UnityEngine;

public abstract class MVAvatar : MVGroup, IHealRayAttachementObject, IUpdatecontrollerSubscriberLateUpdate, IUpdatecontrollerSubscriberBase
{
	public const int DefaultBaseMaxHelth = 100;

	protected const float healParticleSpawnCooldownTime = 1f;

	protected Avatar avatar;

	public MVRuntimeDataVariable<float> Health;

	public MVRuntimeDataVariable<int> MaxHealth;

	private MVRuntimeDataVariableClampedFloat shield;

	public MVRuntimeDataVariable Modifiers;

	public MVRuntimeDataVariable CurrentItem;

	public MVRuntimeDataVariable IsFiring;

	public MVRuntimeDataVariable Animation;

	public MVRuntimeDataVariable SpawnRoleModeTypes;

	public MVRuntimeDataVariableClampedFloat Size;

	public LimbRotationRuntimeData LimbRotationRuntimeData;

	protected float healParticleSpawnTime;

	protected AvatarPickupOwner avatarPickupOwner;

	protected AvatarLimbManager limbManager;

	protected WorldObjectSkillDataManager skillDataManager;

	private readonly Vector3 characterControllerCenterOffset;

	private Ray lineOfFire;

	private bool isLocal;

	private MVBody body;

	private GameObject healRayAttachmentObject;

	private bool isHidden;

	public Vector3 CharacterControllerCenterOffset => default;

	public float HealParticleSpawnTime
	{
		set
		{
		}
	}

	public MVRuntimeDataVariableClampedFloat Shield
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public PickupItem CurrentPickup => null;

	public AvatarLimbManager LimbManager => null;

	public MVBody Body => null;

	public Avatar Avatar => null;

	public bool IsSeated => false;

	public int SeatID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsHidden
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float SetTransparency
	{
		set
		{
		}
	}

	public abstract Vector3 VelocityRelative { get; }

	public abstract Vector3 VelocityAbsolute { get; }

	public MVWorldObjectClient WorldObjectClient => null;

	protected virtual void OnSeatedChanged(bool isSeated)
	{
	}

	public virtual void BeforeVehicleEntered()
	{
	}

	public virtual void OnEnterVehicle()
	{
	}

	public virtual void OnLeaveVehicle()
	{
	}

	public bool IsInMode(SpawnRoleModeType t)
	{
		return false;
	}

	public MVAvatar(Dictionary<object, object> data, GameObject avatarPrefab, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base((Dictionary<object, object>)null, (GameObject)null, (Dictionary<int, MVWorldObjectClient>)null)
	{
	}

	public override void Initialize()
	{
	}

	public override void Destroy()
	{
	}

	public void SetTeam()
	{
	}

	public void UpdateControllerLateUpdate()
	{
	}

	protected void HandleLeaveVehicle()
	{
	}

	protected virtual void AvatarStateChangedHandler(object a)
	{
	}

	private void InitializeModifiers()
	{
	}

	public override void AddChild(MVWorldObjectClient child)
	{
	}

	public override void TransferChild(int id)
	{
	}

	protected virtual void AttachBody(MVBody newBody)
	{
	}

	protected void TrySpawningHealParticles(float previousHealth, float currentHealth)
	{
	}

	public GameObject GetHealRayAttachmentObject()
	{
		return null;
	}

	protected void OnStateChangeToHidden()
	{
	}

	protected virtual void OnAnimationChange(object newAnimationData)
	{
	}

	protected virtual void OnHealthChange(object newHealthData)
	{
	}

	protected virtual void OnShieldChange(object newShieldData)
	{
	}

	protected virtual void OnCurrentPickupChange(object newPickupDataData)
	{
	}
}
