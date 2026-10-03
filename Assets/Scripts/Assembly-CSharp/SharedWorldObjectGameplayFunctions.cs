using System.Collections.Generic;
using MV.WorldObject.RuntimeEvents;
using UnityEngine;

public class SharedWorldObjectGameplayFunctions
{
	public static class Explosion
	{
		private static readonly int layerMask;

		private static void ApplyProximityDamage(Vector3 position, float damageValue, float damageRadius, float shockwaveAcceleration, bool local, ExplosionEvent explosionEvent, HashSet<int> ignoreIDs)
		{
		}

		public static void Explode(ParticleSystem particlePrefab, Vector3 position, float damageValue, float damageRadius, float shockwaveAcceleration, bool local, ExplosionEvent explosionEvent, HashSet<int> ignoreIDs)
		{
		}
	}

	private static bool DoParticleEffect(Vector3 position)
	{
		return false;
	}

	public static void DustEfffect(ParticleSystem particlePrefab, Vector3 position, float radius)
	{
	}
}
