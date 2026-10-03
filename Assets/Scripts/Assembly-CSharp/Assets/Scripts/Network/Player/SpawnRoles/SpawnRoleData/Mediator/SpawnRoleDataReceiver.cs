using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.Network.Player.SpawnRoles.SpawnRoleData.SpawnRoleVariableTypes;
using MV.Common;
using UnityEngine;

namespace Assets.Scripts.Network.Player.SpawnRoles.SpawnRoleData.Mediator
{
	public class SpawnRoleDataReceiver
	{
		public SpawnRoleReceiverVariable<int> woId;

		public SpawnRoleReceiverVariable<SpawnRoleModeType> spawnRoleMode;

		public SpawnRoleReceiverVariable<bool> isSeated;

		public SpawnRoleReceiverVariable<float> health;

		public SpawnRoleReceiverVariable<int> maxHealth;

		public SpawnRoleReceiverVariable<float> shield;

		public SpawnRoleReceiverVariable<bool> isInGunMode;

		public SpawnRoleReceiverVariable<bool> pickupItemIsInHand;

		public SpawnRoleReceiverVariable<bool> isInVehicle;

		public SpawnRoleReceiverVariable<Vector3> position;

		public SpawnRoleReceiverVariable<Quaternion> rotation;

		public SpawnRoleReceiverVariable<Vector3> defaultScale;

		public SpawnRoleReceiverVariable<Vector3> scale;

		public SpawnRoleReceiverVariable<float> size;

		public SpawnRoleReceiverVariable<ReviveState> reviveState;

		public SpawnRoleReceiverVariable<LastRespawnType> lastRespawnType;

		public SpawnRoleReceiverVariable<GamePassTier> tierRequirement;

		[CompilerGenerated]
		private Action<int, int, PlayerKilledByType> m_OnKilled;

		[CompilerGenerated]
		private Action m_OnSuicide;

		protected bool isActive;

		public bool IsActive => false;

		public event Action<int, int, PlayerKilledByType> OnKilled
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnSuicide
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void NotifyKilled(int localPlayerActorNr, int dmgDealerActorNr, PlayerKilledByType damageType)
		{
		}

		public void NotifySuicide()
		{
		}
	}
}
