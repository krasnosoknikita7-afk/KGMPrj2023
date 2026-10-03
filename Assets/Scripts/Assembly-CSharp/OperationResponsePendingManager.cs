using System.Collections.Generic;
using ExitGames.Client.Photon;
using MV.Common;

public class OperationResponsePendingManager
{
	private HashSet<MVOperationCodes> pendingOperations;

	private PhotonPeer peer;

	public OperationResponsePendingManager(PhotonPeer peer)
	{
	}

	public bool AddOperationCodeToPending(MVOperationCodes operationCode, Dictionary<byte, object> data)
	{
		return false;
	}

	public void TryRemovePendingOperation(MVOperationCodes operationCode)
	{
	}

	public bool IsOperationPending(MVOperationCodes operationCode)
	{
		return false;
	}
}
