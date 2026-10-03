using System;

namespace Borodar.FarlandSkies.CloudyCrownPro.DotParams
{
	[Serializable]
	public class CelestialParamsList : SortedParamsList<CelestialParam>
	{
		public CelestialParam GetParamPerTime(float currentTime)
		{
			return null;
		}
	}
}
