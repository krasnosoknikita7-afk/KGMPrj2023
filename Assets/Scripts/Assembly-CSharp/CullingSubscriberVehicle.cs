using UnityEngine;

public class CullingSubscriberVehicle : CullingSubscriberBase
{
	private GameObject visualRoot;

	private const int vehicleDistanceBandIndex = 2;

	public CullingSubscriberVehicle(GameObject visualRoot)
	{
	}

	public override void OnStateChanged(CullingGroupEvent cullingGroupEvent)
	{
	}

	public void PositionChanged(MVWorldObjectClient arg0, PositionChangedEventArgs positionChangedEventArgs)
	{
	}
}
