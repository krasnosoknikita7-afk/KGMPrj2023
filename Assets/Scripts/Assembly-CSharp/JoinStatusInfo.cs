using System.Collections.Generic;
using MV.Common;
using UnityEngine;

public class JoinStatusInfo : MonoBehaviour
{
	private MVEventCodes prevGameState;

	private MVConnState prevConnState;

	private static readonly HashSet<MVEventCodes> createGameSnapshotEvents;

	protected void Update()
	{
	}
}
