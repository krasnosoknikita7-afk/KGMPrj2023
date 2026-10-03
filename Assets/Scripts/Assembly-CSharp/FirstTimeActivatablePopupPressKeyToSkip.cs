using System.Collections.Generic;
using UnityEngine;

public class FirstTimeActivatablePopupPressKeyToSkip : FirstTimeActivatableElementBase
{
	[SerializeField]
	private GameObject popup;

	[SerializeField]
	private float minLifeTime;

	[SerializeField]
	private List<KogamaControls> keysToDetect;

	private float currentlifeTime;

	private bool visible;

	public override bool CanShow => false;

	private void Update()
	{
	}

	public override void OnShow()
	{
	}

	protected override void OnDisable()
	{
	}

	private void Clear()
	{
	}

	private void OnShown()
	{
	}
}
