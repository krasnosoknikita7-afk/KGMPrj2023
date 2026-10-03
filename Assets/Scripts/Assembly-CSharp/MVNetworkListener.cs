using System.Collections.Generic;
using UnityEngine;

public class MVNetworkListener : MVNetworkObject
{
	private HashSet<INetworkUpdateListener> updateListenerList;

	private Queue<NetworkTransformPackage> transformQueue;

	private NetworkTransformPackage currentPackage;

	private NetworkTransformPackage nextPackage;

	private bool transformReportingHasStopped;

	private bool stopListening;

	public override bool RemoveFromUpdate => false;

	public MVNetworkListener(MVWorldObjectClient owner)
		: base(null)
	{
	}

	private NetworkTransformPackage CreateCurPosTransformPackage()
	{
		return null;
	}

	public void SetToCurrentPosition()
	{
	}

	public void SetOwnerTransformToMostResentPackage()
	{
	}

	public void AddTransformPackage(NetworkTransformPackage p)
	{
	}

	public void RmoveNetorkUpdateListener(INetworkUpdateListener listener)
	{
	}

	public override void Update(MVNetworkGame game)
	{
	}

	private void UpdateTransform(MVNetworkGame game, int delayedTime)
	{
	}

	private Vector3 ExtrapolatePosition(float interpFactor)
	{
		return default;
	}

	private Quaternion ExtrapolateRotation(float interpFactor)
	{
		return default;
	}
}
