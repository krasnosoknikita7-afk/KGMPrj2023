using System.Collections.Generic;

public class MVCameraSettings : MVLogicObject
{
	private bool isPreview;

	private bool needToUnsubscribeToSettingsCallback;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public override bool HasInputConnector => false;

	public override bool HasOutputConnector => false;

	protected override bool HasVisualsInPlaymode => false;

	public MVCameraSettings(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	public override void InitializeInventory()
	{
	}

	public override void OnDataUpdate()
	{
	}

	public override bool IsSingletonObject()
	{
		return false;
	}

	public override void Destroy()
	{
	}

	private void OnCameraSettingAdded()
	{
	}

	private void UpdateStaticValues()
	{
	}
}
