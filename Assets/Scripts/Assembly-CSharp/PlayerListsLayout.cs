using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MV.WorldObject;
using UnityEngine;

public class PlayerListsLayout : MonoBehaviour
{
	private class ScoreSorter : IComparer<MVPlayer>
	{
		public int Compare(MVPlayer data1, MVPlayer data2)
		{
			return 0;
		}

		private int PlayerValue(MVPlayer data)
		{
			return 0;
		}
	}

	[CompilerGenerated]
	private sealed class _003CCreatePlayerLists_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<MVTeam> teams;

		public PlayerListsLayout _003C_003E4__this;

		public IEnumerable<MVPlayer> players;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CCreatePlayerLists_003Ed__10(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private PlayerListsLayout playerListsPrefab;

	[SerializeField]
	private PlayerListBase playerListPrefab;

	[SerializeField]
	private GameObject topGrid;

	[SerializeField]
	private GameObject bottomGrid;

	private GameStatCounterType typeToDisplay;

	private UIPushOption pushOptions;

	public void Initialize(PlayerListsLayout playerListsPrefab, GameStatCounterType typeToDisplay, UIPushOption pushOptions)
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void ReCreate()
	{
	}

	[IteratorStateMachine(typeof(_003CCreatePlayerLists_003Ed__10))]
	private IEnumerator CreatePlayerLists(IEnumerable<MVPlayer> players, List<MVTeam> teams)
	{
		return null;
	}

	private PlayerListBase CreatePlayerList(MVTeam team, int score)
	{
		return null;
	}

	private Dictionary<MVTeam, List<MVPlayer>> GetSortedTeamLists(IEnumerable<MVPlayer> players, List<MVTeam> teams)
	{
		return null;
	}

	private void SortPlayerListsAfterScore(Dictionary<MVTeam, PlayerListBase> playerLists, List<MVTeam> teams, GameStatCounterType typeToDisplay)
	{
	}
}
