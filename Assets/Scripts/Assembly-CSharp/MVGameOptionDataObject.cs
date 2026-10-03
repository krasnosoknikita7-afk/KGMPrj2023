using System.Collections.Generic;
using MV.WorldObject.KogamaSettings.KogamaSettingsCore.Client;
using MV.WorldObject.KogamaSettings.KogamaSettingsCore.KogamaSettingTypes;
using MV.WorldObject.KogamaSettings.SpecializedSettingsTypes.GameBoosterSettings;
using MV.WorldObject.KogamaSettings.SpecializedSettingsTypes.GameOptions;
using UnityEngine;

public class MVGameOptionDataObject : MVWorldObjectClient
{
	private readonly SettingsReporter setttingsReporter;

	private readonly SettingsManager settingsManager;

	public GameBoosterSettingsManager GameBoosterSettingsManager => null;

	public GameOptionSettingsManager GameOptionSettingsManager => null;

	public MVGameOptionDataObject(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base((Dictionary<object, object>)null, (GameObject)null, (Dictionary<int, MVWorldObjectClient>)null)
	{
	}

	public void UpdateSetting(KogamaSettingWrapperBase obj)
	{
	}

	public void RemoveSetting(KogamaSettingWrapperBase obj)
	{
	}

	public void Submit()
	{
	}

	public override void PartialUpdateWOData(Dictionary<object, object> woData)
	{
	}

	public override void PartialRemoveFromWOData(Dictionary<object, object> entriesToRemove)
	{
	}

	private void PartialDataRemove(int arg1, Dictionary<object, object> arg2)
	{
	}

	private void PartialDataUpdate(int arg1, Dictionary<object, object> arg2)
	{
	}
}
