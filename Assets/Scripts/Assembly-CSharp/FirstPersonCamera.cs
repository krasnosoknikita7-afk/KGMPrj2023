using System.Collections.Generic;
using UnityEngine;

public abstract class FirstPersonCamera : MVCameraBase
{
	[Header("Configuration")]
	[SerializeField]
	private float cameraHeight;

	[SerializeField]
	protected float maxLookAngleDownward;

	[SerializeField]
	protected float maxLookAngleUpward;

	[HideInInspector]
	[SerializeField]
	private Vector3 cameraOffset;

	[SerializeField]
	protected float pitchSensitivity;

	[SerializeField]
	protected float yawSensitivity;

	[SerializeField]
	private FirstPersonWeaponBob weaponBob;

	[Header("Dependencies")]
	[SerializeField]
	private DamageIndicator damageIndicator;

	[SerializeField]
	private ModifierIndicator modifierIndicator;

	[SerializeField]
	private HealingIndicator healingIndicator;

	[SerializeField]
	protected TargetRotation smoothRotation;

	protected Vector2 targetRotation;

	private MVAvatarLocal localAvatar;

	private List<MeshRenderer> vehiclesHiddenMeshRenderers;

	private bool haveHiddenVehicle;

	public override CameraType CameraType => CameraType.ThirdPerson;

	public override float FieldOfView => 0f;

	protected abstract void UpdateCameraRotation();

	public override void Reset()
	{
	}

	public void Initialize(MVAvatarLocal avatarLocal)
	{
	}

	private void Initialize()
	{
	}

	public override void Enter(MVCameraController cameraController)
	{
	}

	public override void Resume(MVCameraController cameraController)
	{
	}

	public override void Exit(MVCameraController camController)
	{
	}

	public override void Suspend(MVCameraController camController)
	{
	}

	private void ActivateFirstPerson()
	{
	}

	private void OnDestroy()
	{
	}

	private void DeactivateFirstPerson()
	{
	}

	private void MoveItemToFirstpersonView(PickupItem item)
	{
	}

	private void HideBody(bool shouldHideBody)
	{
	}

	private void HideBlinking(bool shouldHideBlinking)
	{
	}

	private void HideVehicle()
	{
	}

	private void ShowVehicle()
	{
	}

	public override void UpdateCamera(MVCameraController camController, ProtectedTransform targetTransform)
	{
	}

	private void UpdateCameraPosition()
	{
	}

	private void UpdateAvatar()
	{
	}
}
