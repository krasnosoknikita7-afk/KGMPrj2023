using System.Collections.Generic;
using MV.WorldObject;
using MV.WorldObject.RuntimeEvents;

public class RuntimeEventManager
{
	private class AccumulatedCubeDamages : IUpdatecontrollerSubscriberUpdate, IUpdatecontrollerSubscriberBase
	{
		private class AccumulatedCubeDamage
		{
			private const float intervalInSecondsBeforeReset = 5f;

			private float lastReceivedDamage;

			private float damage;

			public bool Expired => false;

			public float AddDamage(float damageDelta)
			{
				return 0f;
			}
		}

		private Dictionary<IntVector, AccumulatedCubeDamage> accumulatedCubeDamages;

		public float AddDamageToCube(float damage, IntVector position)
		{
			return 0f;
		}

		public void UpdateControllerUpdate()
		{
		}

		public void Clear()
		{
		}

		public void UpdateControllerFixedUpdate()
		{
		}
	}

	protected MVCubeModelPrototypeTerrain cubeModelPrototypeTerrain;

	protected MVCubeModelFineGrainedTerrain cubeModelFineGrainedTerrain;

	private readonly AccumulatedCubeDamages localAccumulatedCubeDamages;

	protected bool doEffects;

	public void ResetTerrain()
	{
	}

	public void SendRuntimeEvent(ExplosionEvent explosion)
	{
	}

	public void ExecuteRuntimeEventLocal(ExplosionEvent explosion)
	{
	}

	public bool SendRemoveOneFineGrainedCube(VoxelHit voxelHit, float damage)
	{
		return false;
	}

	public void SendRuntimeEvent(SingleCubeFineGrainedEvent singleCubeFineGrainedEvent)
	{
	}

	private bool IsRemovingAddedFineGrainedCube(SingleCubeFineGrainedEvent singleCubeFineGrainedEvent)
	{
		return false;
	}

	protected bool HandleEvent(SingleCubeFineGrainedEvent singleCubeFineGrainedEvent)
	{
		return false;
	}

	protected bool HandleEvent(ExplosionEvent explosion)
	{
		return false;
	}
}
