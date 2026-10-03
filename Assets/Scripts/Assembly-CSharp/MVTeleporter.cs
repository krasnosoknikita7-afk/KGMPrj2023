using System.Collections.Generic;
using UnityEngine;

public class MVTeleporter : MVLogicObject
{
	private const UseGUIResult purchaseOptions = UseGUIResult.CanAfford | UseGUIResult.CannotAfford;

	private List<int> avatarIgnoreList;

	private MVTeleporterObject teleportObject;

	private TeleportAvatar teleportAvatarPrefab;

	private MVTeleporter target;

	private UseInteractor useInteractor;

	private bool isDestroyed;

	public override Vector3 InputConnectorOffset => default;

	public override Vector3 ObjectConnectorOffset => default;

	public override Quaternion ObjectConnectorRotation => default;

	public override bool HasInputConnector => false;

	public override bool HasOutputConnector => false;

	public override bool HasObjectConnector => false;

	protected override bool HasVisualsInPlaymode => false;

	public MVTeleporter Target
	{
		set
		{
		}
	}

	public MVTeleporter(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	public override void InitializeInventory()
	{
	}

	private void SetupUseInteractor()
	{
	}

	public override void OnDataUpdate()
	{
	}

	public override bool Delete(MVWorldObjectClientManager worldObjectClientManager, ref string errorText)
	{
		return false;
	}

	public override bool ValidateObjectLinkTarget(MVWorldObjectClient wo)
	{
		return false;
	}

	public override Vector3 GetClosestGridPoint(float gridSize, Vector3 position)
	{
		return default;
	}

	private void triggerBoxEvents_TriggerEnter(object sender, TriggerEventArgs e)
	{
	}

	private bool DoTeleport(int instigatorWOID)
	{
		return false;
	}

	private void triggerBoxEvents_TriggerExit(object sender, TriggerEventArgs e)
	{
	}

	public override void Destroy()
	{
	}
}
