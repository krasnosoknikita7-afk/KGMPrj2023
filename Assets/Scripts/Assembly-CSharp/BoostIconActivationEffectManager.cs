using System.Collections.Generic;
using MV.Common;
using UnityEngine;

public class BoostIconActivationEffectManager : MonoBehaviour
{
	[SerializeField]
	private BoostIconActivationEffectController boostIconEffectPrefab;

	private List<BoostIconActivationEffectController> boostIconEffects;

	private int nextActiveBoostEffect;

	private SpawnRoleModeType previousMode;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnAvatarModeChange(SpawnRoleModeType newMode)
	{
	}

	private void OnAvatarSpawn()
	{
	}

	private void StartBoostIconEffect()
	{
	}
}
