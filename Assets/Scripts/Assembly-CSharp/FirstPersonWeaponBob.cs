using System;
using UnityEngine;

[Serializable]
public class FirstPersonWeaponBob
{
	[SerializeField]
	[Tooltip("Bobs per second.")]
	private float bobFrequency;

	[Tooltip("Units by time")]
	[SerializeField]
	private AnimationCurve bob;

	[SerializeField]
	private Vector3 bobAxis;

	[SerializeField]
	private float bobMultiplier;

	[Tooltip("Degrees by time")]
	[SerializeField]
	private AnimationCurve rotation;

	[SerializeField]
	private Vector3 rotationAxis;

	[SerializeField]
	private float rotationMultiplier;

	private Transform weapon;

	private Vector3 weaponPosition;

	private Quaternion weaponRotation;

	public void Initialize(Transform weapon)
	{
	}

	public void Update()
	{
	}
}
