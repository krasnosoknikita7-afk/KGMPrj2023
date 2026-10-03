using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AvatarCapture : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDrawAvatarRoutine_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AvatarCapture _003C_003E4__this;

		public Transform cameraTransform;

		public Transform objectTransform;

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
		public _003CDrawAvatarRoutine_003Ed__12(int _003C_003E1__state)
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

	[SerializeField]
	private Camera renderCam;

	[SerializeField]
	private Vector3 cameraOffset;

	[Tooltip("Space between players on winningscreen")]
	[SerializeField]
	private Vector3 formationSpacing;

	[SerializeField]
	private float formationRandomness;

	public Camera RenderCam
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public void CaptureAllPlayersInGame()
	{
	}

	public void CapturePlayersInTeam(List<ScoreTeamEntry> scoreTeamEntries, GameStatCounterType counterType)
	{
	}

	private void CapturePlayerGroup(List<List<MVPlayer>> sortedList)
	{
	}

	public void CapturePlayer(List<MVPlayer> players)
	{
	}

	private void InitializeCamera()
	{
	}

	[IteratorStateMachine(typeof(_003CDrawAvatarRoutine_003Ed__12))]
	private IEnumerator DrawAvatarRoutine(Transform cameraTransform, Transform objectTransform)
	{
		return null;
	}

	private void DrawObject(Transform cameraTransform, Transform objectTransform)
	{
	}

	private static Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angles)
	{
		return default;
	}

	private int CreateTriangleFormation(ref List<Vector3> positions, Vector3 formationSpacing, int numberOfPositions)
	{
		return 0;
	}

	private int CreateTriangleFormation(ref List<Vector3> positions, Vector3 formationSpacing, int positionsRemaining, int unitsThisRow, float targetY, float targetZ)
	{
		return 0;
	}

	private Vector3 CalculateTieOffset(int currentWinner, int amountOfWinners)
	{
		return default;
	}

	private void OnDestroy()
	{
	}
}
