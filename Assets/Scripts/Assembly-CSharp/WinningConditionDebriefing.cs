using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WinningConditionDebriefing : MonoBehaviour, IDebriefing
{
	[CompilerGenerated]
	private sealed class _003CShowDebriefingCoroutine_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WinningConditionDebriefing _003C_003E4__this;

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
		public _003CShowDebriefingCoroutine_003Ed__16(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CWaitForFadeOut_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WinningConditionDebriefing _003C_003E4__this;

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
		public _003CWaitForFadeOut_003Ed__19(int _003C_003E1__state)
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

	private const float fadeTime = 0.3f;

	[SerializeField]
	private CanvasGroup group;

	[SerializeField]
	private DebriefingWinnerGUI playerWinPrefab;

	[SerializeField]
	private DebriefingWinnerGUI teamWinPrefab;

	[SerializeField]
	private DebriefingWinnerGUI noWinnerPrefab;

	[SerializeField]
	private AvatarCapture captureCameraPrefab;

	private DebriefingWinnerGUI debriefing;

	private AvatarCapture captureCamera;

	private void Start()
	{
	}

	private void OnWinningConditionReceived(IWinningCondition winningCondition)
	{
	}

	private void GenerateDebriefing(IWinningCondition winningCondition)
	{
	}

	public void SetupDebriefing(WinningConditionType winType, HighScores highScores, bool teamMode)
	{
	}

	private void SetupDebriefingPlayer(WinningConditionType winType, List<ScoreActorEntry> scoreActorEntries, GameStatCounterType counterType)
	{
	}

	private void SetupDebriefingTeam(WinningConditionType winType, List<ScoreTeamEntry> scoreTeamEntries, GameStatCounterType counterType)
	{
	}

	private void OnDisable()
	{
	}

	private void SetupDebriefingNoWinner()
	{
	}

	[IteratorStateMachine(typeof(_003CShowDebriefingCoroutine_003Ed__16))]
	private IEnumerator ShowDebriefingCoroutine()
	{
		return null;
	}

	private void Clear()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForFadeOut_003Ed__19))]
	private IEnumerator WaitForFadeOut()
	{
		return null;
	}

	private static string FormatCount(GameStatCounterType statType, int count)
	{
		return null;
	}

	private void RenderPlayerToRenderTexture(List<int> actorNrs)
	{
	}

	private List<ScoreTeamEntry> GetWinningTeamsFromScoreTeamEntries(List<ScoreTeamEntry> scoreTeamEntries, GameStatCounterType counterType)
	{
		return null;
	}

	private List<ScoreActorEntry> GetWinningActorsFromScoreActorEntries(List<ScoreActorEntry> scoreActorEntries, GameStatCounterType counterType)
	{
		return null;
	}

	private void ResetScoreWhenDone()
	{
	}
}
