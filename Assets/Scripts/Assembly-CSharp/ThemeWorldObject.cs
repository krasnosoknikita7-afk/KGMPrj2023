using System.Collections.Generic;
using UnityEngine;

public class ThemeWorldObject : MVWorldObjectClient
{
	public bool SkyboxOverride => false;

	public Dictionary<object, object> SettingsData => null;

	public string Identifier => null;

	public Theme Visualization { get; private set; }

	public ThemeWorldObject(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base((Dictionary<object, object>)null, (GameObject)null, (Dictionary<int, MVWorldObjectClient>)null)
	{
	}

	public override void Initialize()
	{
	}

	public override void Destroy()
	{
	}

	public void CommitSettings()
	{
	}

	public override void Reset()
	{
	}

	public override void OnDataUpdate()
	{
	}
}
