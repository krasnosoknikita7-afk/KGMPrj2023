using System;

namespace Borodar.FarlandSkies.CloudyCrownPro.DotParams
{
	[Serializable]
	public class SkyParamsList : SortedParamsList<SkyParam>
	{
		public SkyParam GetParamPerTime(float currentTime)
		{
			return null;
		}
	}
}
