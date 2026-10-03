using System;
using System.Runtime.CompilerServices;
using MV.Common;
using MV.WorldObject.MetaData;
using UnityEngine;

public class GameEventManager
{
	private class GameEventSubscribableVariable<T> : SubscribableVariableBase<T>
	{
		public T ValueSet
		{
			set
			{
			}
		}

		public GameEventSubscribableVariable(T value)
			: base(default(T))
		{
		}
	}

	public class GameStateManager
	{
		public Action OnEnableLobbyState;

		public Action OnDisableLobbyState;

		private GameEventSubscribableVariable<MVGameStateType> gameStateType;

		public SubscribableVariableBase<MVGameStateType> GameStateType => null;

		public void NotifyGameStateType(MVGameStateType gameState)
		{
		}
	}

	public class AvatarCommandsPlayModeManager
	{
		[CompilerGenerated]
		private Action m_OnKillSelf;

		[CompilerGenerated]
		private Action m_OnSetRespawnWhenPossible;

		[CompilerGenerated]
		private Action m_OnReadyScreenShot;

		[CompilerGenerated]
		private Action m_OnEnterPlaymode;

		[CompilerGenerated]
		private Action m_OnSetToSpawnPoint;

		[CompilerGenerated]
		private Action<WinningConditionType> m_OnWinningConditionIntermediateDebriefing;

		[CompilerGenerated]
		private Action m_OnRemoveFromGame;

		[CompilerGenerated]
		private Action m_OnRespawn;

		[CompilerGenerated]
		private Action m_OnSetToDeadMode;

		[CompilerGenerated]
		private Action<int> m_OnMoveBodyToSafeSpot;

		[CompilerGenerated]
		private Action<int> m_OnSpawnAtSafeSpot;

		[CompilerGenerated]
		private Action m_OnSpawnAsGhost;

		[CompilerGenerated]
		private Action m_OnReviveTimeElapsed;

		public event Action OnKillSelf
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

		public event Action OnSetRespawnWhenPossible
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

		public event Action OnReadyScreenShot
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

		public event Action OnEnterPlaymode
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

		public event Action OnSetToSpawnPoint
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

		public event Action<WinningConditionType> OnWinningConditionIntermediateDebriefing
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

		public event Action OnRemoveFromGame
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

		public event Action OnRespawn
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

		public event Action OnSetToDeadMode
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

		public event Action<int> OnMoveBodyToSafeSpot
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

		public event Action<int> OnSpawnAtSafeSpot
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

		public event Action OnSpawnAsGhost
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

		public event Action OnReviveTimeElapsed
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

		public void KillSelf()
		{
		}

		public void ReviveTimeElapsed()
		{
		}

		public void EnterPlayingState()
		{
		}

		public void SetToDeadMode()
		{
		}

		public void Respawn()
		{
		}

		public void SetToSpawnPoint()
		{
		}

		public void SpawnAsGhost()
		{
		}

		public void SetRespawnWhenPossible()
		{
		}

		public void MoveBodyToSafeSpot(int index)
		{
		}

		public void SpawnAtSafeSpot(int safeSpotIndex)
		{
		}

		public void SetIntermediateDebriefing(WinningConditionType winningConditionType)
		{
		}

		public void RemoveFromGame()
		{
		}

		public void ReadyScreenShot()
		{
		}
	}

	public class AvatarCommandsBuildModeManager
	{
		public class LaserCommandsManager
		{
			[CompilerGenerated]
			private Action<bool> m_OnLaserActiveChanged;

			[CompilerGenerated]
			private Action<byte> m_OnCubeMaterialChanged;

			[CompilerGenerated]
			private Action<LaserPointerState> m_OnChangeState;

			[CompilerGenerated]
			private Action<Vector3> m_OnUpdatePosition;

			[CompilerGenerated]
			private Action<float> m_OnActivateLaserForDuration;

			public event Action<bool> OnLaserActiveChanged
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

			public event Action<byte> OnCubeMaterialChanged
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

			public event Action<LaserPointerState> OnChangeState
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

			public event Action<Vector3> OnUpdatePosition
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

			public event Action<float> OnActivateLaserForDuration
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

			public void SetLaserActiveState(bool isActive)
			{
			}

			public void SetCurrentCubeMaterial(byte cubeMaterial)
			{
			}

			public void ChangeState(LaserPointerState newState)
			{
			}

			public void UpdatePosition(Vector3 to)
			{
			}

			public void ActivateLaserForDuration(float duration)
			{
			}
		}

		[CompilerGenerated]
		private Action<EditorEvent, object> m_OnEnterBuildStateEvent;

		[CompilerGenerated]
		private Action<EditorEvent, object> m_OnExitBuildStateEvent;

		[CompilerGenerated]
		private Action<Vector3, Quaternion> m_OnSetSpawn;

		public readonly LaserCommandsManager LaserCommands;

		[CompilerGenerated]
		private Action m_OnSetToEditMode;

		public event Action<EditorEvent, object> OnEnterBuildStateEvent
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

		public event Action<EditorEvent, object> OnExitBuildStateEvent
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

		public event Action<Vector3, Quaternion> OnSetSpawn
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

		public event Action OnSetToEditMode
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

		public void SetSpawn(Vector3 position, Quaternion rotation)
		{
		}

		public void SetToEditMode()
		{
		}

		public void EnterBuildStateEvent(EditorEvent editorEvent, object eventData)
		{
		}

		public void ExitBuildStateEvent(EditorEvent editorEvent, object eventData)
		{
		}
	}

	private GameEventSubscribableVariable<int> gameEventSubscribableVariable;

	public readonly AvatarCommandsPlayModeManager AvatarCommandsPlayMode;

	public readonly AvatarCommandsBuildModeManager AvatarCommandsBuildMode;

	public readonly GameStateManager GameState;

	[CompilerGenerated]
	private Action<FirstTimeEvent> m_OnFirstTimeEvent;

	[CompilerGenerated]
	private Action<int> m_OnXPRewarded;

	public event Action<FirstTimeEvent> OnFirstTimeEvent
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

	public event Action<int> OnXPRewarded
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

	public void NotifyFirstTimeEvent(FirstTimeEvent firstTimeEvent)
	{
	}

	public void NotifyXPDeltaAmount(int xp)
	{
	}
}
