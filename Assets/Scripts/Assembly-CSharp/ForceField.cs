using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TriggerBoxEvents))]
public class ForceField : MonoBehaviour
{
	[SerializeField]
	private TriggerBoxEvents triggerBoxEvents;

	[SerializeField]
	private CapsuleCollider trigger;

	[SerializeField]
	private float strength;

	private HashSet<MVInteractableBase> interactablesInField;

	private HashSet<MVRigidBody> bodiesInField;

	private void Awake()
	{
	}

	private void OnExit(object sender, TriggerEventArgs e)
	{
	}

	private void OnEnter(object sender, TriggerEventArgs e)
	{
	}

	private void ApplyForceTo(MVRigidBody body)
	{
	}

	private void ApplyNoFriction(MVInteractableBase interactable)
	{
	}

	private void FixedUpdate()
	{
	}
}
