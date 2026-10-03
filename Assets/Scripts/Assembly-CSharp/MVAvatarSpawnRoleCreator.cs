using System;
using System.Collections.Generic;
using MV.Common;
using MV.WorldObject;
using MV.WorldObject.KogamaSettings.KogamaSettingsCore.Client;
using MV.WorldObject.KogamaSettings.SpecializedSettingsTypes.AttributeSettings;
using MV.WorldObject.SpawnRoles;
using UnityEngine;

public class MVAvatarSpawnRoleCreator : MVBlueprintBase, ISpawnRolePreviewObject
{
	private MVAvatarSpawnRoleCreatorObject spawnRoleCreatorObject;

	private bool isInWorld;

	private UseInteractor useInteractor;

	private readonly SettingsReporter settingsReporter;

	private CullingSubscriberDynamic cullingSubscriberDynamic;

	public Action OnBodyUpdate;

	public Action OnRedoObjectLinks;

	public const string teamKey = "team";

	public const string tierKey = "RequiredRank";

	private int AvatarRuntimePrototypeRoot { get; set; }

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	private MVPreviewAvatar AvatarPrototype => null;

	public AttributeSettingsManager AttributeSettingsManagerAvatar => null;

	public MVTeam Team
	{
		get
		{
			return MVTeam.Blue;
		}
		set
		{
		}
	}

	public GamePassTier Tier
	{
		get
		{
			return GamePassTier.Tier0;
		}
		set
		{
		}
	}

	public MVAvatarSpawnRoleCreator(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null)
	{
	}

	public override void Initialize()
	{
	}

	public override void InitializeInventory()
	{
	}

	public void UpdateAvatarBody(SpawnRoleBodySwitchData spawnRoleBodySwitchData, bool removedObjectLinks)
	{
	}

	public GameObject GetSpawnRolePreviewObject()
	{
		return null;
	}

	public MVTeam GetTeamRequirement()
	{
		return MVTeam.Blue;
	}

	public GamePassTier GetTierRequirement()
	{
		return GamePassTier.Tier0;
	}

	public override void OnDataUpdate()
	{
	}

	public override void PartialUpdateWOData(Dictionary<object, object> woData)
	{
	}

	public override void PartialRemoveFromWOData(Dictionary<object, object> entriesToRemove)
	{
	}

	public override void Destroy()
	{
	}

	public override bool Delete(MVWorldObjectClientManager worldObjectClientManager, ref string errorText)
	{
		return false;
	}

	public override Vector3 GetClosestGridPoint(float gridSize, Vector3 position)
	{
		return default;
	}

	private void SettingsReporterOnOnValueRemovedLocal(Dictionary<object, object> obj)
	{
	}

	private void SettingsReporterOnOnValueChangedLocal(Dictionary<object, object> obj)
	{
	}

	private void PartialDataRemove(int arg1, Dictionary<object, object> arg2)
	{
	}

	private void PartialDataUpdate(int arg1, Dictionary<object, object> arg2)
	{
	}

	private void HideBody()
	{
	}

	private void TryShowBody()
	{
	}

	private void ShowBody(MVWorldObjectClient originalBody)
	{
	}
}
