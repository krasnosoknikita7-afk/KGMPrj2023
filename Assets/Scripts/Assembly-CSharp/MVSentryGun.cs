using System.Collections.Generic;
using MV.Common;
using MV.WorldObject;
using UnityEngine;

public class MVSentryGun : MVLogicObject, ILogicWorldObject
{
	private float laserRange;

	private float pushBackStrength;

	private ClientSideNPCInteractable interactable;

	private InteractionPackageType interactionType;

	private IntervalWithRandomSeed intervalWithRandomSeed;

	private Dictionary<int, SentryGunBeam> woIdsBeamsMap;

	private List<int> deleteList;

	private float glowFactor;

	private SentryGunBeamType beamType;

	private MVSentryGunObject gunObject;

	private const float cullingRadius = 2f;

	private bool wasDead;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public IInputSignalReceiver InputSignalReceiver { get; private set; }

	public override bool HasInputConnector => false;

	public override bool HasOutputConnector => false;

	protected override bool HasVisualsInPlaymode => false;

	public override Vector3 InputConnectorOffset => default;

	public HashSet<int> RaycastIgnoreWorldObjectIds { get; set; }

	public SentryGunBeamType BeamType => SentryGunBeamType.FireBeam;

	public MVSentryGun(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	private void OnPositionChanged(MVWorldObjectClient wo, PositionChangedEventArgs positionChangedEventArgs)
	{
	}

	private void OnStateChange(CullingGroupEvent cullingGroupEvent)
	{
	}

	public override void Destroy()
	{
	}

	public override void InitializeInventory()
	{
	}

	public void InitializeCommon()
	{
	}

	public void ReceiveDamage(float amount, MVPlayer damageDealer, PlayerKilledByType damageType)
	{
	}

	private void UpdateSentryState()
	{
	}

	public override void Select(Color color)
	{
	}

	public override void DeSelect()
	{
	}

	public override void Reset()
	{
	}

	private bool DoRespawn()
	{
		return false;
	}

	protected override void OnUpdate()
	{
	}

	private void DoFrameDelete()
	{
	}

	private bool HitsTarget(Ray ray, int woID)
	{
		return false;
	}

	private void ApplyDamage(MVWorldObjectClient wo, InteractionDataHandlerBase interactionDataHandlerBase)
	{
	}

	private static InteractionData BeamTypeToInteractionPackageType(SentryGunBeamType btype, Vector3 impulse)
	{
		return default;
	}

	public override bool CompareWithKoGaMaPackage(MVWorldObjectClient wo, KoGaMaPackageClient koGaMaPackageClient, ref int insertedBy)
	{
		return false;
	}

	public override bool OnClickHandler(EditorStateMachine esm, Collider collider)
	{
		return false;
	}
}
