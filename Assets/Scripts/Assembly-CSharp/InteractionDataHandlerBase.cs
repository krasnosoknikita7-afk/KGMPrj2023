using MV.WorldObject;
using UnityEngine;

public abstract class InteractionDataHandlerBase : MVComponent
{
	[SerializeField]
	private ClosestPointBase closestPoint;

	public abstract MVTeam Team { get; }

	public Vector3 GetClosestPoint(Vector3 from)
	{
		return default;
	}

	public virtual bool CanHandle(InteractionPackageType interactionPackageType, bool interactionIsLocal)
	{
		return false;
	}

	public abstract bool HandleInteraction(MVPickupOwner interactor, InteractionData interaction, bool interactionIsLocal);

	public bool HandleInteraction(InteractionData interaction, bool interactionIsLocal)
	{
		return false;
	}

	protected virtual void OnValidate()
	{
	}

	protected override void Awake()
	{
	}

	protected bool IsFriendlyFire(MVPickupOwner interactor)
	{
		return false;
	}
}
