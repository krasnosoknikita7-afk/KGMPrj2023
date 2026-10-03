using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.Network.Player.SpawnRoles.SpawnRoleData.SpawnRoleVariableTypes;
using MV.Common;
using UnityEngine;

namespace Assets.Scripts.Network.Player.SpawnRoles.SpawnRoleData.Mediator
{
	public class SpawnRoleDataMediator
	{
		protected class SpawnRoleDataReceiverInternal : SpawnRoleDataReceiver
		{
			public void DeActivate()
			{
			}
		}

		protected class SpawnRoleVariableInternal<T> : SpawnRoleVariable<T>
		{
			public SubscribableVariable<T> SubscribableVariable => null;

			public SpawnRoleVariableInternal(T value)
				: base(default(T))
			{
			}
		}

		protected SpawnRoleDataReceiverInternal spawnRoleDataReceiver;

		public readonly SpawnRoleModeTypeWrapper SpawnRoleModeTypeWrapper;

		[CompilerGenerated]
		private Action<int, int, PlayerKilledByType> m_OnKilled;

		[CompilerGenerated]
		private Action m_OnSuicide;

		protected readonly SpawnRoleVariableInternal<int> woId;

		protected readonly SpawnRoleVariableInternal<SpawnRoleModeType> spawnRoleMode;

		protected readonly SpawnRoleVariableInternal<bool> isSeated;

		protected readonly SpawnRoleVariableInternal<float> health;

		protected readonly SpawnRoleVariableInternal<int> maxHealth;

		protected readonly SpawnRoleVariableInternal<float> shield;

		protected readonly SpawnRoleVariableInternal<bool> isInGunMode;

		protected readonly SpawnRoleVariableInternal<bool> isInVehicle;

		protected readonly SpawnRoleVariableInternal<Vector3> position;

		protected readonly SpawnRoleVariableInternal<Quaternion> rotation;

		protected readonly SpawnRoleVariableInternal<Vector3> scale;

		protected readonly SpawnRoleVariableInternal<Vector3> defaultScale;

		protected readonly SpawnRoleVariableInternal<float> size;

		protected readonly SpawnRoleVariableInternal<LastRespawnType> lastRespawnType;

		protected readonly SpawnRoleVariableInternal<bool> pickupItemIsInHand;

		protected readonly SpawnRoleVariableInternal<ReviveState> reviveState;

		protected readonly SpawnRoleVariableInternal<GamePassTier> tierRequirement;

		public SpawnRoleVariable<int> WoId => null;

		public SpawnRoleVariable<SpawnRoleModeType> SpawnRoleMode => null;

		public SpawnRoleVariable<bool> IsSeated => null;

		public SpawnRoleVariable<float> Health => null;

		public SpawnRoleVariable<int> MaxHealth => null;

		public SpawnRoleVariable<float> Shield => null;

		public SpawnRoleVariable<bool> IsInGunMode => null;

		public SpawnRoleVariable<bool> IsInVehicle => null;

		public SpawnRoleVariable<Vector3> Position => null;

		public SpawnRoleVariable<Quaternion> Rotation => null;

		public SpawnRoleVariable<bool> PickupItemIsInHand => null;

		public SpawnRoleVariable<Vector3> DefaultScale => null;

		public SpawnRoleVariable<Vector3> Scale => null;

		public SpawnRoleVariable<GamePassTier> TierRequirement => null;

		public SpawnRoleVariable<float> Size => null;

		public SpawnRoleVariable<ReviveState> ReviveState => null;

		public SpawnRoleVariable<LastRespawnType> LastAvatarRespawnType => null;

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

		public void ActivateSpawnRole(ISpawnRoleLocal currentSpawnRole, ISpawnRoleLocal prevSpawnRole, Vector3 newPosition, Quaternion newRotation)
		{
		}

		private void DeActivatePrevSpawnRoleDataReceiver(ISpawnRoleLocal prevSpawnRole)
		{
		}

		private void SetupNewSpawnRoleDataReceiver()
		{
		}

		protected void SpawnRoleDataReceiverOnOnKilled(int localPlayerActorNr, int dmgDealerActorNr, PlayerKilledByType damageType)
		{
		}

		protected void SpawnRoleDataReceiverOnOnSuicide()
		{
		}
	}
}
