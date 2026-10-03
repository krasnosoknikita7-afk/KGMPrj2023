using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SizeState
{
	private static readonly int layerMask;

	private readonly MVInteractable interactableLocal;

	private readonly MvCharacterController controllerLocal;

	private float currentSize;

	private const float scalePercent = 0.1f;

	[CompilerGenerated]
	private EventHandler m_EquipSlapGunEvent;

	[CompilerGenerated]
	private EventHandler<ScaleArgs> m_CameraScaleEvent;

	[CompilerGenerated]
	private EventHandler<EventArgs> m_UnEquipSlapGunEvent;

	private static List<Vector3> relativePositions;

	public float ControllerRadius => 0f;

	public float ControllerCenterY => 0f;

	private float AvatarScale => 0f;

	public event EventHandler EquipSlapGunEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event EventHandler<ScaleArgs> CameraScaleEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event EventHandler<EventArgs> UnEquipSlapGunEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public SizeState(MVInteractable interactable, MvCharacterController controller)
	{
	}

	public void UpdateScale()
	{
	}

	public void OnScalingWhileColliding(MVControllerColliderHit hitData)
	{
	}

	public void ScaleChanged()
	{
	}

	private Vector3 FindValidMoveLocation(float scale)
	{
		return default;
	}

	public bool GetIsValidScaledRelativePosition(Vector3 relativeTestPos, float scale)
	{
		return false;
	}

	public bool GetIsValidScaledPosition(Vector3 position, float scale)
	{
		return false;
	}

	public void MoveOutOfScalingCollision(MVControllerColliderHit hitData)
	{
	}
}
