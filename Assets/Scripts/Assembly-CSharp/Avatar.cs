using System.Collections.Generic;
using UnityEngine;
using WorldObjectTypes.Avatar.Shared;

public class Avatar : MonoBehaviour, IBulletImpactVisualizer, IMovable
{
	public MVAvatar mvAvatar;

	private bool isLocal;

	private Dictionary<AvatarModifierPackageType, AvatarModifier> modifiers;

	private Dictionary<AvatarModifierPackageType, byte> currentModifierByteState;

	private byte[] modifierEffectCount;

	private InteractionDataHandlerBase interactionDataHandler;

	private Collider avatarCollider;

	[SerializeField]
	private AvatarLevelUp avatarLevelUp;

	[SerializeField]
	private AvatarFader avatarFader;

	[SerializeField]
	public GameObject root;

	[SerializeField]
	private AvatarBulletImpactVisualizer bulletImpactVisualizer;

	[SerializeField]
	private WaterSplashComponent waterSplashComponent;

	[SerializeField]
	private AvatarEnabledChangeHandler enabledChangeHandler;

	[SerializeField]
	protected AvatarUIHandler avatarUIHandler;

	[SerializeField]
	private ChatAnchor chatBubbleAnchor;

	[SerializeField]
	private AvatarPaused avatarPaused;

	public bool IsLocal => false;

	public InteractionDataHandlerBase InteractionDataHandlerBase => null;

	public Collider Collider => null;

	public AvatarFader AvatarFader => null;

	public AvatarEnabledChangeHandler EnabledChangeHandler => null;

	public AvatarUIHandler AvatarUIHandler => null;

	public ChatAnchor ChatBubbleAnchor => null;

	public Vector3 Velocity => default;

	public Bounds Bounds => default;

	public Vector3 Position => default;

	public virtual void Initialize(MVAvatar mvAvatar, bool isLocal)
	{
	}

	public void UpdateModifiers(Dictionary<object, object> newModifiers)
	{
	}

	public void OnEnterVehicle()
	{
	}

	public void OnExitVehicle()
	{
	}

	public void StartBlinking(BlinkType type, float duration = float.PositiveInfinity)
	{
	}

	public void StopBlinking(BlinkType type)
	{
	}

	public void VisualizeBulletImpact(VoxelHit voxelHit, Ray lineOfFire, int shooterActorNumber, float damage = 100f)
	{
	}

	public bool HasModifierEffect(AvatarModifierEffect modifierEffect)
	{
		return false;
	}
}
