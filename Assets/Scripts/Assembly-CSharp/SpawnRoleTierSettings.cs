using System.Collections.Generic;
using MV.Common;
using UnityEngine;
using UnityEngine.Events;

public class SpawnRoleTierSettings : MonoBehaviour
{
	[SerializeField]
	private List<GameObject> tierSelectedEffectObjects;

	[SerializeField]
	private GameObject tierZero;

	[SerializeField]
	private GameObject tierZeroGray;

	private bool canSelectTier0;

	private UnityAction<GamePassTier> OnChangeTierCallback;

	public void Initialize(GamePassTier currentTier, bool canSelectTier0, UnityAction<GamePassTier> OnChangeTierCallback)
	{
	}

	public void OnSelectTier0()
	{
	}

	public void OnSelectTier1()
	{
	}

	public void OnSelectTier2()
	{
	}

	public void OnSelectTier3()
	{
	}

	private void SelectTier(GamePassTier newTier)
	{
	}
}
