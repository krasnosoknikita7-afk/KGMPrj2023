using System.Collections.Generic;

public class MVSoundEmitter : MVLogicObject, ILogicWorldObject
{
	private SoundEmitterObject soundEmitterObject;

	private SoundLoader soundLoader;

	private const string defaultUrl = "AmbientAudio/Nature/kgm_amb_forest.unity3d";

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public override bool HasInputConnector => false;

	public override bool HasOutputConnector => false;

	protected override bool HasVisualsInPlaymode => false;

	public IInputSignalReceiver InputSignalReceiver { get; private set; }

	public MVSoundEmitter(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override void Initialize()
	{
	}

	public override void OnDataUpdate()
	{
	}

	private void InputStateUpdateCallback(LogicInputState logicInputState, LogicObjectManager logicObjectManager)
	{
	}

	public override void Destroy()
	{
	}

	public override bool Delete(MVWorldObjectClientManager worldObjectClientManager, ref string errorText)
	{
		return false;
	}

	public void UpdateSound()
	{
	}

	private bool ShouldPlay()
	{
		return false;
	}

	private static float GetMinDistanceFromRangeAmbient(SoundRangeDistance range)
	{
		return 0f;
	}

	private static float GetMaxDistanceFromRangeAmbient(SoundRangeDistance range)
	{
		return 0f;
	}
}
