using System.Collections.Generic;
using UnityEngine;

public class MVAvatarRemote : MVAvatar, IBulletImpactVisualizer, ISpawnRoleRemote
{
	private DynamicCullingHandler cullingHandler;

	private CapsuleCollider triggerCollider;

	private AvatarRemoteMovementCalculator avatarRemoteMovementCalculator;

	private const float initialCullingRadius = 3.5f;

	private float impulseMagnitudeFactor;

	private float velocityMinMagnitude;

	private float velocityMaxMagnitude;

	private float minVelocity;

	private const float hitTimeOut = 2f;

	private float prevHitTime;

	public bool IsInVehicle { get; private set; }

	public override Vector3 VelocityRelative => default;

	public override Vector3 VelocityAbsolute => default;

	int ISpawnRoleRemote.Id => 0;

	public MVAvatarRemote(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	private void OnResume()
	{
	}

	private void OnObserve()
	{
	}

	private void InitAvatarState()
	{
	}

	public override void Destroy()
	{
	}

	private void InitializeHealth()
	{
	}

	private void InitializeShield()
	{
	}

	private CapsuleCollider CreateTriggerCollider()
	{
		return null;
	}

	protected override void OnAnimationChange(object newAnimationData)
	{
	}

	private void triggerBoxEvents_TriggerEnter(object sender, TriggerEventArgs e)
	{
	}

	protected override void AvatarStateChangedHandler(object a)
	{
	}

	private void ShowBody()
	{
	}

	private void HideBody()
	{
	}

	protected override void AttachBody(MVBody newBody)
	{
	}

	public override void OnEnterVehicle()
	{
	}

	public override void OnLeaveVehicle()
	{
	}

	public void VisualizeBulletImpact(VoxelHit voxelHit, Ray lineOfFire, int shooterActorNumber, float damage = 100f)
	{
	}

	public void Activate(int idFrom, Vector3 position, Quaternion rotation)
	{
	}

	public void DeActivate(int idTo)
	{
	}
}
