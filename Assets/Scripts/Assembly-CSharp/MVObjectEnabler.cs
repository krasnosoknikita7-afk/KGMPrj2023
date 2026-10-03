using System.Collections.Generic;

public class MVObjectEnabler : MVLogicObject, ILogicWorldObject
{
	private bool isInitialized;

	private ObjectEnabler goObjectEnabler;

	private bool showingOutline;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public override bool HasInputConnector => false;

	public override bool HasOutputConnector => false;

	public override bool HasObjectConnector => false;

	protected override bool HasVisualsInPlaymode => false;

	public IInputSignalReceiver InputSignalReceiver { get; private set; }

	public bool ShowingOutline => false;

	public MVObjectEnabler(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override bool ValidateObjectLinkTarget(MVWorldObjectClient wo)
	{
		return false;
	}

	public override void Initialize()
	{
	}

	private void InputStateUpdateCallback(LogicInputState logicInputState, LogicObjectManager logicObjectManager)
	{
	}

	public override void Destroy()
	{
	}

	private void OnEditModeChange(EditModeChangeArgs arg)
	{
	}

	public override void PlayModeInitialize()
	{
	}

	public override void Reset()
	{
	}

	private void UpdateShowObjects()
	{
	}

	public override void OnObjectLinkChanged()
	{
	}

	public override void OnDataUpdate()
	{
	}

	private void ShowObjects(bool visible)
	{
	}
}
