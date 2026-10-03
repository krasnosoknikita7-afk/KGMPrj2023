using System;
using Borodar.FarlandSkies.CloudyCrownPro.DotParams;
using UnityEngine;

public class DayNightCycleColorPresets : ScriptableObject
{
	[Serializable]
	public class Preset
	{
		[SerializeField]
		private string name;

		[SerializeField]
		private SkyParamsList skyParamList;

		[SerializeField]
		private CelestialParamsList sunParamsList;

		[SerializeField]
		private CelestialParamsList moonParamsList;

		[SerializeField]
		private StarsParamsList starsParamList;

		private bool initialized;

		public string Name => null;

		public SkyParamsList Sky => null;

		public CelestialParamsList Sun => null;

		public CelestialParamsList Moon => null;

		public StarsParamsList Stars => null;

		public bool IsInitialized => false;

		public void Initialize()
		{
		}

		public void TranslateName()
		{
		}

		public void Cleanup()
		{
		}

		private void LanguageLoadedCallback()
		{
		}
	}

	[SerializeField]
	private Preset[] presets;

	public int Length => 0;

	public Preset this[int i] => null;

	protected void OnEnable()
	{
	}

	protected void OnDisable()
	{
	}

	protected void TranslatePresetNames()
	{
	}
}
