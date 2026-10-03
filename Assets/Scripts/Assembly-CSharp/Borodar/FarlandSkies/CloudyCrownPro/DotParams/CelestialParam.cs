using System;
using UnityEngine;

namespace Borodar.FarlandSkies.CloudyCrownPro.DotParams
{
	[Serializable]
	public class CelestialParam : DotParam
	{
		public Color TintColor;

		public Color LightColor;

		[Range(0f, 8f)]
		public float LightIntencity;
	}
}
