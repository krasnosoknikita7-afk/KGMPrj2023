using System.Collections.Generic;
using IngameController.MVEditor;
using MV.Common;
using UnityEngine;
using WorldObjectInteractionSystem.UseSystem;
using WorldObjectTypes.VehiclesBase.Shared;

public class PrefabPool : MonoBehaviour
{
	[SerializeField]
	private EnumPoolManager enumPoolManager;

	private static PrefabPool instance;

	[Header("World Objects")]
	[SerializeField]
	private ObjectPrefab mvFirePrefab;

	[SerializeField]
	private ObjectPrefab mvAndPrefab;

	[SerializeField]
	private GameObject mvLocalAvatarPrefab;

	[SerializeField]
	private GameObject mvRemoteAvatarPrefab;

	[SerializeField]
	private GameObject mvLocalAvatarBuildModePrefab;

	[SerializeField]
	private GameObject mvRemoteAvatarBuildModePrefab;

	[SerializeField]
	private GameObject mvPreviewAvatarPrefab;

	[SerializeField]
	private AdvancedGhostObject mvAdvancedGhostPrefab;

	[SerializeField]
	private MVBodyObject mvBodyPrefab;

	[SerializeField]
	private MVAvatarSpawnRoleCreatorObject mvAvatarSpawnRoleCreatorPrefab;

	[SerializeField]
	private VehicleBaseObject mvHamsterWheelPrefab;

	[SerializeField]
	private VehicleBaseObject mvHoverCraftPrefab;

	[SerializeField]
	private CollectTheItemDropOffObject collectTheItemDropOff;

	[SerializeField]
	private CollectTheItemObject collectTheItemCollectable;

	[SerializeField]
	private CollectTheItemLineObject collectTheItem;

	[SerializeField]
	private ObjectiveArrow collectTheItemDropOffArrow;

	[SerializeField]
	private VehicleBaseObject mvJetPackPrefab;

	[SerializeField]
	private VehicleBaseObject mvJetPackDeluxePrefab;

	[SerializeField]
	private ObjectPrefab mvBatteryPrefab;

	[SerializeField]
	private ObjectPrefab mvCameraSettingsPrefab;

	[SerializeField]
	private MVCollectibleObject mvCollectiblePrefab;

	[SerializeField]
	private MVCollectibleObject mvCollectibleFantaPrefab;

	[SerializeField]
	private ObjectPrefab mvCheckpointPrefab;

	[SerializeField]
	private ObjectPrefab mvExplosivesPrefab;

	[SerializeField]
	private ObjectPrefab mvFlagPrefab;

	[SerializeField]
	private ObjectPrefab mvGameCoinChestPrefab;

	[SerializeField]
	private MVGameCoinObject mvGameCoinPrefab;

	[SerializeField]
	private GameObject mvGhostPrefab;

	[SerializeField]
	private ObjectPrefab mvGoalPrefab;

	[SerializeField]
	private GameObject mvGhostInstancePrefab;

	[SerializeField]
	private ObjectPrefab mvGravityCubePrefab;

	[SerializeField]
	private ObjectPrefab mvNegatePrefab;

	[SerializeField]
	private MVPointLightObject mvPointLightPrefab;

	[SerializeField]
	private MVPressurePlateObject mvPressurePlatePrefab;

	[SerializeField]
	private ObjectPrefab mvPulseBoxPrefab;

	[SerializeField]
	private ObjectPrefab mvRandomBoxPrefab;

	[SerializeField]
	private ObjectPrefab mvRoundCubePrefab;

	[SerializeField]
	private ObjectPrefab mvSkyboxPrefab;

	[SerializeField]
	private ObjectPrefab mvSmokePrefab;

	[SerializeField]
	private SoundEmitterObject mvSoundEmitterPrefab;

	[SerializeField]
	private SoundEmitterObject mvGloablSoundEmitterPrefab;

	[SerializeField]
	private ObjectPrefab mvSpawnPointBluePrefab;

	[SerializeField]
	private ObjectPrefab mvSpawnPointGreenPrefab;

	[SerializeField]
	private ObjectPrefab mvSpawnPointRedPrefab;

	[SerializeField]
	private ObjectPrefab mvSpawnPointYellowPrefab;

	[SerializeField]
	private MVTextMsgObject mvTextMsgPrefab;

	[SerializeField]
	private ObjectPrefab mvTimeTriggerPrefab;

	[SerializeField]
	private ObjectPrefab mvToggleBoxPrefab;

	[SerializeField]
	private MVTriggerBoxObject mvTriggerBoxPrefab;

	[SerializeField]
	private GameObject mvMovingPlatformGroupPrefab;

	[SerializeField]
	private GameObject mvMovingPlatformNodePrefab;

	[SerializeField]
	private MVObjectEnablerObject mvObjectEnablerPrefab;

	[SerializeField]
	private ObjectPrefab mvKillLimitPrefab;

	[SerializeField]
	private ObjectPrefab mvOculusKillLimitPrefab;

	[SerializeField]
	private MVSentryGunObject mvSentryGunPrefab;

	[SerializeField]
	private ShootableButtonObject shootableButtonPrefab;

	[SerializeField]
	private GameObject mvTeleportGroupPrefab;

	[SerializeField]
	private MVTeleporterObject mvTeleporterPrefab;

	[SerializeField]
	private UseLeverObject useLeverPrefab;

	[SerializeField]
	private ObjectPrefab mvWaterPlanePrefab;

	[SerializeField]
	private WindTurbineObject windTurbinePrefab;

	[SerializeField]
	private MVCountingCubeObject mvCountingCubePrefab;

	[SerializeField]
	private TeleportAvatar teleportAvatarPrefab;

	[SerializeField]
	private SpawnerObject spawnerObject;

	[SerializeField]
	private ObjectPrefab timeAttackFlagPrefab;

	[SerializeField]
	private MVGamePointObject gamePointPrefab;

	[SerializeField]
	private TriggerCubePrefab triggerCubePrefab;

	[SerializeField]
	private ObjectPrefab teamEditorPrefab;

	[SerializeField]
	private ObjectPrefab gamePointChestPrefab;

	[SerializeField]
	private ObjectPrefab vehicleEnergyPrefab;

	[SerializeField]
	private ObjectPrefab doorPrefab;

	[SerializeField]
	[Header("Game")]
	[Space(20f)]
	private Material ghostMarkerMaterial;

	[SerializeField]
	private Material objectHiddenMaterial;

	[SerializeField]
	private SentryGunBeam iceBeamObject;

	[SerializeField]
	private SentryGunBeam fireBeamObject;

	[SerializeField]
	private StarDisplayObject starDisplayPrefab;

	[SerializeField]
	private RewardedAdDisplayObject rewardedAdDisplayPrefab;

	[SerializeField]
	private LevelDisplayCube levelDisplayPrefab;

	[SerializeField]
	private GameRankDisplayObject gameRankDisplayPrefab;

	[SerializeField]
	private GameCoinDisplayObject gameCoinDisplayPrefab;

	[SerializeField]
	private CubeModelChunkPrefab cubeModelChunkPrefab;

	[SerializeField]
	private Material blinkerDefaultMaterial;

	[SerializeField]
	[Space(20f)]
	[Header("Pick up")]
	private MVPickupItemBaseObject avatarCenterGunPrefab;

	[SerializeField]
	private MVPickupItemBaseObject avatarImpulseGunPrefab;

	[SerializeField]
	private MVPickupItemBaseObject avatarHealthPrefab;

	[SerializeField]
	private MVPickupItemBaseObject avatarBazookaPrefab;

	[SerializeField]
	private MVPickupItemBaseObject avatarRailGunPrefab;

	[SerializeField]
	private MVPickupItemBaseObject avatarMutantPrefab;

	[SerializeField]
	private MVPickupItemBaseObject avatarSwordPrefab;

	[SerializeField]
	private MVPickupItemBaseObject avatarMeleeWeaponPrefab;

	[SerializeField]
	private MVPickupItemBaseObject avatarShotgunPrefab;

	[SerializeField]
	private MVPickupItemBaseObject avatarFlamethrowerPrefab;

	[SerializeField]
	private MVPickupItemBaseObject avatarCubeGunPrefab;

	[SerializeField]
	private MVPickupItemBaseObject avatarNinjaRunPrefab;

	[SerializeField]
	private MVPickupItemBaseObject avatarSixShooterPrefab;

	[SerializeField]
	private MVPickupItemBaseObject avatarDoubleSixShooterPrefab;

	[SerializeField]
	private MVPickupItemBaseObject avatarThrowingStarPrefab;

	[SerializeField]
	private MVPickupItemBaseObject avatarMultiThrowingStarPrefab;

	[SerializeField]
	private MVPickupItemBaseObject avatarMouseGunPrefab;

	[SerializeField]
	private MVPickupItemBaseObject avatarGrowthGunPrefab;

	[SerializeField]
	private MVPickupItemBaseObject avatarMousePackPrefab;

	[SerializeField]
	private MVPickupItemBaseObject avatarGrowthPackPrefab;

	[SerializeField]
	private MVPickupItemBaseObject avatarHealRayPrefab;

	[SerializeField]
	private MVPickupItemBaseObject avatarCostumePrefab;

	[SerializeField]
	[Space(20f)]
	[Header("Avatar item pick up")]
	private GameObject avatarItemCenterGun;

	[SerializeField]
	private GameObject avatarItemImpulseGun;

	[SerializeField]
	private GameObject avatarItemLaserPointer;

	[SerializeField]
	private GameObject avatarItemBazooka;

	[SerializeField]
	private GameObject avatarItemHand;

	[SerializeField]
	private GameObject avatarItemRailGun;

	[SerializeField]
	private GameObject avatarItemSword;

	[SerializeField]
	private GameObject avatarItemMeleeWeapon;

	[SerializeField]
	private GameObject avatarItemShotgun;

	[SerializeField]
	private GameObject avatarItemFlamethrower;

	[SerializeField]
	private GameObject avatarItemCubeGun;

	[SerializeField]
	private GameObject avatarItemSixShooter;

	[SerializeField]
	private GameObject avatarItemDoubleSixShooter;

	[SerializeField]
	private GameObject avatarItemThrowingStar;

	[SerializeField]
	private GameObject avatarItemMultiThrowingStar;

	[SerializeField]
	private GameObject avatarItemGrowthGun;

	[SerializeField]
	private GameObject avatarItemMouseGun;

	[SerializeField]
	private GameObject avatarItemSlapGun;

	[SerializeField]
	private GameObject avatarItemCollectTheItem;

	[SerializeField]
	private GameObject avatarItemHealRay;

	[SerializeField]
	private GameObject avatarItemCostume;

	[Header("Avatar modifier")]
	[SerializeField]
	[Space(20f)]
	private AvatarModifier shieldModifier;

	[Space(20f)]
	[Header("Particles")]
	[SerializeField]
	private GameObject particleCFX_GroundAura;

	[SerializeField]
	private ParticleSystem particleCubeDust;

	[SerializeField]
	private ParticleSystem particleCubeDustDestroyed;

	[SerializeField]
	private ParticleSystem particleExplosion;

	[SerializeField]
	private ParticleSystem particleFluffySmoke;

	[SerializeField]
	private ParticleSystem goldExplosion;

	[SerializeField]
	private ParticleSystem poisonParticles;

	[SerializeField]
	private ParticleSystem collectTheItemParticles;

	[SerializeField]
	private ParticleSystem healingParticles;

	[Header("Logic object prefabs")]
	[Space(20f)]
	[SerializeField]
	private GameObject logicInputConnectorPrefab;

	[SerializeField]
	private GameObject logicOutputConnectorPrefab;

	[SerializeField]
	private GameObject logicObjectConnectorPrefab;

	[SerializeField]
	private LinkObjectScript linkObject;

	[SerializeField]
	private ObjectLinkObjectScript objectLinkObject;

	[SerializeField]
	private Material logicCubeConnectorRedMaterial;

	[SerializeField]
	private Material logicCubeConnectorRedSelectedMaterial;

	[SerializeField]
	private Material logicCubeConnectorBlueMaterial;

	[SerializeField]
	private Material logicCubeConnectorBlueSelectedMaterial;

	[SerializeField]
	[Space(20f)]
	[Header("GUI")]
	private Texture2D avatarAccessoryMoveIcon;

	[SerializeField]
	private GameObject drawPlaneObject;

	[SerializeField]
	private Material modelConstraintsMaterial;

	[Header("UGUI")]
	[Space(20f)]
	[SerializeField]
	private AvatarInputControllerAndroidSettings avatarInputControllerAndroidSettings;

	[SerializeField]
	private Texture2D crosshairCursor;

	[SerializeField]
	private MaterialButtonTextureGenerator materialButtonTextureGenerator;

	[SerializeField]
	private InsertCursor insertCursor;

	[SerializeField]
	private ChatBubble chatBubble;

	[SerializeField]
	[Header("TextBubbleContent")]
	private RectTransform editCornerHelpText;

	[SerializeField]
	private RectTransform editEdgeHelpText;

	[SerializeField]
	private RectTransform editFaceHelpText;

	[SerializeField]
	[Header("Editor")]
	[Space(20f)]
	[Space(20f)]
	[Header("Cameras")]
	private Material cellCursorErrorMaterial;

	[SerializeField]
	private Material cellCursorMaterial;

	[SerializeField]
	private Material modelCubeSpaceMaterial;

	[SerializeField]
	private Material cursor2dEdgeMaterial;

	[SerializeField]
	private Material cursor2dCornerMaterial;

	[SerializeField]
	private Material cursorMaterial;

	[SerializeField]
	private Material cursorCornerMaterial;

	[SerializeField]
	private Material cursorNoneMaterial;

	[SerializeField]
	private Material insertPreviewMaterial;

	[SerializeField]
	private Material previewBoxMaterial;

	[SerializeField]
	private Material selectBoxMaterial;

	[SerializeField]
	private SphereVolumeIndicator rangeVisualizationObject;

	[SerializeField]
	private LineRangeIndicator lineRangeIndicator;

	[SerializeField]
	private AdvancedGhostIcon ghostEditorIconObject;

	[SerializeField]
	private Material indentMaterial;

	[SerializeField]
	private TransformGizmo transformGizmo;

	[SerializeField]
	[Header("Touch")]
	[Space(20f)]
	public GameObject touchDetectionHandlerPrefab;

	private Dictionary<AvatarItemType, EquipableData> pickupPrefabLUT;

	private Dictionary<MVJetPack.JetPackType, VehicleBaseObject> jetPackPrefabLUT;

	private Dictionary<bool, EquipableData> meleeWeaponPrefabLUT;

	public EnumPoolManager EnumPoolManager => null;

	public static PrefabPool Instance => null;

	public ObjectPrefab MVAvatarSpawnRoleCreatorPrefab => null;

	public ObjectPrefab MVFirePrefab => null;

	public ObjectPrefab MVAndPrefab => null;

	public GameObject MVLocalAvatarPrefab => null;

	public GameObject MVRemoteAvatarPrefab => null;

	public GameObject MVAvatarLocalBuildModePrefab => null;

	public GameObject MVAvatarRemoteBuildModePrefab => null;

	public GameObject MVPreviewAvatarPrefab => null;

	public AdvancedGhostObject MVAdvancedGhostPrefab => null;

	public MVBodyObject MVBodyPrefab => null;

	public VehicleBaseObject MVHamsterWheelPrefab => null;

	public VehicleBaseObject MVHoverCraftPrefab => null;

	public CollectTheItemDropOffObject CollectTheItemDropOffPrefab => null;

	public CollectTheItemObject CollectTheItemCollectablePrefab => null;

	public CollectTheItemLineObject CollectTheItemPrefab => null;

	public ObjectiveArrow CollectTheItemDropOffArrowPrefab => null;

	public VehicleBaseObject MVJetPackPrefab => null;

	public VehicleBaseObject MVJetPackDeluxePrefab => null;

	public ObjectPrefab MVBatteryPrefab => null;

	public ObjectPrefab MVCameraSettingsPrefab => null;

	public ObjectPrefab TeamEditorPrefab => null;

	public MVCollectibleObject MVCollectiblePrefab => null;

	public MVCollectibleObject MVCollectibleFantaPrefab => null;

	public ObjectPrefab MVCheckpointPrefab => null;

	public ObjectPrefab MVExplosivesPrefab => null;

	public ObjectPrefab MVFlagPrefab => null;

	public ObjectPrefab MVGameCoinChestPrefab => null;

	public MVGameCoinObject MVGameCoinPrefab => null;

	public GameObject MVGhostPrefab => null;

	public ObjectPrefab MVGoalPrefab => null;

	public GameObject MVGhostInstancePrefab => null;

	public ObjectPrefab MVGravityCubePrefab => null;

	public ObjectPrefab MVNegatePrefab => null;

	public MVPointLightObject MVPointLightPrefab => null;

	public MVPressurePlateObject MVPressurePlatePrefab => null;

	public ObjectPrefab MVPulseBoxPrefab => null;

	public ObjectPrefab MVRandomBoxPrefab => null;

	public ObjectPrefab MVRoundCubePrefab => null;

	public ObjectPrefab MVSkyboxPrefab => null;

	public ObjectPrefab MVSmokePrefab => null;

	public SoundEmitterObject MVSoundEmitterPrefab => null;

	public SoundEmitterObject MVGlobalSoundEmitterPrefab => null;

	public ObjectPrefab MVSpawnPointBluePrefab => null;

	public ObjectPrefab MVSpawnPointGreenPrefab => null;

	public ObjectPrefab MVSpawnPointRedPrefab => null;

	public ObjectPrefab MVSpawnPointYellowPrefab => null;

	public MVTextMsgObject MVTextMsgPrefab => null;

	public ObjectPrefab MVTimeTriggerPrefab => null;

	public ObjectPrefab MVToggleBoxPrefab => null;

	public MVTriggerBoxObject MVTriggerBoxPrefab => null;

	public GameObject MVMovingPlatformGroupPrefab => null;

	public GameObject MVMovingPlatformNodePrefab => null;

	public MVObjectEnablerObject MVObjectEnablerPrefab => null;

	public ObjectPrefab MVKillLimitPrefab => null;

	public ObjectPrefab MVOculusKillLimitPrefab => null;

	public MVSentryGunObject MVSentryGunPrefab => null;

	public ShootableButtonObject ShootableButtonPrefab => null;

	public GameObject MVTeleportGroupPrefab => null;

	public MVTeleporterObject MVTeleporterPrefab => null;

	public UseLeverObject UseLeverPrefab => null;

	public ObjectPrefab MVWaterPlanePrefab => null;

	public WindTurbineObject WindTurbinePrefab => null;

	public MVCountingCubeObject MVCountingCubePrefab => null;

	public TeleportAvatar TeleportAvatarPrefab => null;

	public SpawnerObject SpawnerObjectPrefab => null;

	public ObjectPrefab TimeAttackFlagPrefab => null;

	public MVGamePointObject GamePointPrefab => null;

	public ObjectPrefab GamePointChestPrefab => null;

	public ObjectPrefab VehicleEnergyPrefab => null;

	public ObjectPrefab DoorPrefab => null;

	public TriggerCubePrefab TriggerCubePrefab => null;

	public Material GhostMarkerMaterial => null;

	public Material ObjectHiddenMaterial => null;

	public SentryGunBeam IceBeamObject => null;

	public SentryGunBeam FireBeamObject => null;

	public StarDisplayObject StarDisplayPrefab => null;

	public RewardedAdDisplayObject RewardedAdDisplayPrefab => null;

	public LevelDisplayCube LevelDisplayPrefab => null;

	public GameRankDisplayObject GameRankDisplayPrefab => null;

	public GameCoinDisplayObject GameCoinDisplayPrefab => null;

	public CubeModelChunkPrefab CubeModelChunkPrefab => null;

	public Material BlinkerDefaultMaterial => null;

	public MVPickupItemBaseObject AvatarCenterGunPrefab => null;

	public MVPickupItemBaseObject AvatarImpulseGunPrefab => null;

	public MVPickupItemBaseObject AvatarHealthPrefab => null;

	public MVPickupItemBaseObject AvatarBazookaPrefab => null;

	public MVPickupItemBaseObject AvatarRailGunPrefab => null;

	public MVPickupItemBaseObject AvatarMutantPrefab => null;

	public MVPickupItemBaseObject AvatarShotgunPrefab => null;

	public MVPickupItemBaseObject AvatarSwordPrefab => null;

	public MVPickupItemBaseObject AvatarMeleeWeaponPrefab => null;

	public MVPickupItemBaseObject AvatarFlamethrowerPrefab => null;

	public MVPickupItemBaseObject AvatarCubeGunPrefab => null;

	public MVPickupItemBaseObject AvatarNinjaRunPrefab => null;

	public MVPickupItemBaseObject AvatarSixShooterPrefab => null;

	public MVPickupItemBaseObject AvatarDoubleSixShooterPrefab => null;

	public MVPickupItemBaseObject AvatarThrowingStarPrefab => null;

	public MVPickupItemBaseObject AvatarMultiThrowingStarPrefab => null;

	public MVPickupItemBaseObject AvatarMouseGunPrefab => null;

	public MVPickupItemBaseObject AvatarGrowthGunPrefab => null;

	public MVPickupItemBaseObject AvatarMousePackPrefab => null;

	public MVPickupItemBaseObject AvatarGrowthPackPrefab => null;

	public MVPickupItemBaseObject AvatarHealRayPrefab => null;

	public MVPickupItemBaseObject AvatarCostumePrefab => null;

	public GameObject AvatarItemCenterGun => null;

	public GameObject AvatarItemImpulseGun => null;

	public GameObject AvatarItemLaserPointer => null;

	public GameObject AvatarItemBazooka => null;

	public GameObject AvatarItemHand => null;

	public GameObject AvatarItemRailGun => null;

	public GameObject AvatarItemSword => null;

	public GameObject AvatarItemMeleeWeapon => null;

	public GameObject AvatarItemShotgun => null;

	public GameObject AvatarItemFlamethrower => null;

	public GameObject AvatarItemCubeGun => null;

	public GameObject AvatarItemSixShooter => null;

	public GameObject AvatarItemDoubleSixShooter => null;

	public GameObject AvatarItemThrowingStar => null;

	public GameObject AvatarItemMultiThrowingStar => null;

	public GameObject AvatarItemGrowthGun => null;

	public GameObject AvatarItemMouseGun => null;

	public GameObject AvatarItemSlapGun => null;

	public GameObject AvatarItemCollectTheItem => null;

	public GameObject AvatarItemHealRay => null;

	public GameObject AvatarItemCostume => null;

	public AvatarModifier ShieldModifier => null;

	public GameObject ParticleCFX_GroundAura => null;

	public ParticleSystem ParticleCubeDust => null;

	public ParticleSystem ParticleCubeDustDestroyed => null;

	public ParticleSystem ParticleExplosion => null;

	public ParticleSystem ParticleFluffySmoke => null;

	public ParticleSystem GoldExplosion => null;

	public ParticleSystem PoisonParticles => null;

	public ParticleSystem CollectTheItemParticles => null;

	public ParticleSystem HealingParticles => null;

	public GameObject LogicInputConnectorPrefab => null;

	public GameObject LogicOutputConnectorPrefab => null;

	public GameObject LogicObjectConnectorPrefab => null;

	public LinkObjectScript LinkObject => null;

	public ObjectLinkObjectScript ObjectLinkObject => null;

	public Material LogicCubeConnectorRedMaterial => null;

	public Material LogicCubeConnectorRedSelectedMaterial => null;

	public Material LogicCubeConnectorBlueMaterial => null;

	public Material LogicCubeConnectorBlueSelectedMaterial => null;

	public Texture2D AvatarAccessoryMoveIcon => null;

	public GameObject DrawPlaneObject => null;

	public Material ModelConstraintsMaterial => null;

	public AvatarInputControllerAndroidSettings AvatarInputControllerAndroidSettings => null;

	public Texture2D CrosshairCursor => null;

	public MaterialButtonTextureGenerator MaterialButtonTextureGenerator => null;

	public InsertCursor InsertCursor => null;

	public ChatBubble ChatBubble => null;

	public Material CellCursorErrorMaterial => null;

	public Material CellCursorMaterial => null;

	public Material ModelCubeSpaceMaterial => null;

	public Material Cursor2dEdgeMaterial => null;

	public Material Cursor2dCornerMaterial => null;

	public Material CursorMaterial => null;

	public Material CursorCornerMaterial => null;

	public Material CursorNoneMaterial => null;

	public Material InsertPreviewMaterial => null;

	public Material PreviewBoxMaterial => null;

	public Material SelectBoxMaterial => null;

	public SphereVolumeIndicator RangeVisualizationObject => null;

	public LineRangeIndicator LineRangeIndicator => null;

	public AdvancedGhostIcon GhostEditorIconObject => null;

	public Material IndentMaterial => null;

	public TransformGizmo TransformGizmo => null;

	public static Dictionary<AvatarItemType, EquipableData> PickupPrefabLUT => null;

	public static Dictionary<MVJetPack.JetPackType, VehicleBaseObject> JetPackPrefabLUT => null;

	protected void Awake()
	{
	}

	protected void OnDestroy()
	{
	}

	public RectTransform CubeEditHelpTextBubble(CubeModelingStateMachine.HoverType t)
	{
		return null;
	}

	public static EquipableData GetPickupPrefab(AvatarItemType avatarItemType, int itemId)
	{
		return default;
	}

	private void BuildLookupTables()
	{
	}
}
