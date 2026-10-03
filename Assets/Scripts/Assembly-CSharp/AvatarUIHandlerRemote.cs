using MV.Common;
using UnityEngine;

public class AvatarUIHandlerRemote : AvatarUIHandler
{
	private Material avatarNameMaterial;

	private Material avatarHealthMaterial;

	private Material avatarShieldMaterial;

	private Material avatarTeamIconMaterial;

	private CullingSubscriberBase cullingSubscriberBase;

	[SerializeField]
	private AvatarBadge avatarBadge;

	[SerializeField]
	private TextMesh avatarName;

	[SerializeField]
	private Renderer healthBarRenderer;

	[SerializeField]
	private Renderer shieldBarRenderer;

	[SerializeField]
	private Renderer teamIconRenderer;

	[SerializeField]
	private HealthBar healthBar;

	[SerializeField]
	private ShieldBar shieldBar;

	[SerializeField]
	private Material teamIconMaterial;

	[SerializeField]
	private Material enemyIconMaterial;

	[SerializeField]
	private Material enemyIconMaterialVisibleThroughWalls;

	[SerializeField]
	private TeamIconScaleWithDistance teamIcon;

	[SerializeField]
	private Transform nameTagLabel;

	[SerializeField]
	private MeshRenderer mobileIcon;

	[SerializeField]
	private Texture androidTexture;

	[SerializeField]
	private Texture iOSTexture;

	[SerializeField]
	private SayChatBubbleHandler sayChatBubbleHandler;

	[SerializeField]
	private GameObject memberFrame;

	private bool shouldShowMobileIcon;

	private bool nameTagLabelVisible;

	private bool forceHideUI;

	private Material EnemyIconMaterial => null;

	public bool NameTagLabelVisible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ForceHideUI
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public HealthBar HealthBar => null;

	public ShieldBar ShieldBar => null;

	public SayChatBubbleHandler SayChatBubbleHandler => null;

	public void ShowMobileIcon(BuildTarget bT)
	{
	}

	public override void Initialize(bool isLocal, MVWorldObjectClient wo, int ownerActorNr, ChatAnchor chatBubbleAnchor)
	{
	}

	public override void SetShouldShowUI(bool shouldShow)
	{
	}

	public override void Activate()
	{
	}

	public override void Deactivate()
	{
	}

	private void OnXRayBoostChanged()
	{
	}

	public override void OnPositionChanged(MVWorldObjectClient arg0, PositionChangedEventArgs positionChangedEventArgs)
	{
	}

	public override void HandleTeamChange()
	{
	}

	public void UpdateHealthBarColor()
	{
	}

	public void UpdateNameTag()
	{
	}

	public void SetHealthBarColor(bool isFriendly)
	{
	}

	private void OnStateChanged(CullingGroupEvent cullingEvent)
	{
	}

	private bool IsOnSameTeamAsLocalAvatar()
	{
		return false;
	}

	private void HideUI()
	{
	}

	protected override void OnDestroy()
	{
	}
}
