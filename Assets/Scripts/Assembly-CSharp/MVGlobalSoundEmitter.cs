using System.Collections.Generic;

public class MVGlobalSoundEmitter : MVLogicObject
{
	private SoundEmitterObject soundEmitterObject;

	private SoundLoader soundLoader;

	private const string defaultUrl = "AmbientAudio/Music/slowstones.unity3d";

	protected override bool HasVisualsInPlaymode => false;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public MVGlobalSoundEmitter(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	public override void OnDataUpdate()
	{
	}

	public void UpdateSound()
	{
	}

	public override void Destroy()
	{
	}

	public override bool Delete(MVWorldObjectClientManager worldObjectClientManager, ref string errorText)
	{
		return false;
	}

	public override bool IsSingletonObject()
	{
		return false;
	}
}
