using System.Collections.Generic;
using UnityEngine;

public class MVFire : MVLogicObject, ILogicWorldObject
{
	private List<MVWorldObjectClient> woList;

	private FireObject fireObject;

	private SphereVolumeIndicator rangeVis;

	private const float damageValue = 100f;

	private const float originalDamageRadius = 2.5f;

	private float damageRadius;

	private const float originalVisualObjectScale = 5f;

	private const float originalParticleSize = 4f;

	private const float fireHitBoxYOffset = 0.04f;

	private const float originalIntensity = 4f;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public override bool HasInputConnector => false;

	public override bool HasOutputConnector => false;

	protected override bool HasVisualsInPlaymode => false;

	public override Vector3 InputConnectorOffset => default;

	public IInputSignalReceiver InputSignalReceiver { get; private set; }

	public MVFire(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	private void OnFireObjectPlaced()
	{
	}

	public override void InitializeInventory()
	{
	}

	private void OnEditModeChange(EditModeChangeArgs arg)
	{
	}

	private void OnInputStateUpdate(LogicInputState logicInputState, LogicObjectManager logicObjectManager)
	{
	}

	private void ToggleEmitter(bool activeFlag)
	{
	}

	private void TriggerAreaEnter(object sender, TriggerEventArgs e)
	{
	}

	private void TriggerAreaExit(object sender, TriggerEventArgs e)
	{
	}

	public override Bounds GetLocalBounds(BoundsContext boundsContext)
	{
		return default;
	}

	protected override void OnUpdate()
	{
	}

	private float CalculateDamageModifier()
	{
		return 0f;
	}

	public override void OnDataUpdate()
	{
	}

	private void SetFireToData()
	{
	}

	private float CalculateDamageRadius(float intensity)
	{
		return 0f;
	}

	private float CalculateScale(float damageRadius)
	{
		return 0f;
	}

	private void UpdateDamageRadius(float intensity)
	{
	}

	private void UpdateScale(float scale)
	{
	}

	private void UpdateSoundVolume(float intensity)
	{
	}

	private void SetCandleAnimation()
	{
	}

	private void SetOriginalAnimation()
	{
	}

	private void RenewCullingSize()
	{
	}

	public override void Destroy()
	{
	}

	private void SetFireHitBoxYOffset(float offset)
	{
	}
}
