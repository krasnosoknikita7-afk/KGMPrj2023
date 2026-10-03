using System;
using System.Collections.Generic;
using MV.Common;
using UnityEngine;

public class BoostParticlesActivationEffect : MonoBehaviour
{
	[Serializable]
	private struct BoosterColors
	{
		public BoostType type;

		public Color rayColor;

		public Color bubbleColor;
	}

	[SerializeField]
	private ParticleSystem rayParticles;

	[SerializeField]
	private ParticleSystem bubbleParticles;

	[SerializeField]
	private List<BoosterColors> boostColors;

	[SerializeField]
	private float activationCooldown;

	private SpawnRoleModeType previousMode;

	private float activationStartTime;

	private List<BoostType> boostsToActivate;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void OnAvatarModeChange(SpawnRoleModeType newMode)
	{
	}

	private void OnAvatarSpawn()
	{
	}

	private void ActivateParticles(BoostType typeToActivate)
	{
	}
}
