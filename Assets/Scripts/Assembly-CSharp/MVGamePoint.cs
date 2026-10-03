using System.Collections.Generic;

public class MVGamePoint : MVGamePointRewardLogicObject
{
	public enum GamePointClientState
	{
		Visible = 0,
		PickedUp = 1,
		ReShowing = 2,
		Invisible = 3
	}

	private GamePointClientState state;

	private bool isVisible;

	private bool canRespawn;

	private int respawnTime;

	private float pickUpTime;

	private const string respawnString = "respawnTime";

	private MVGamePointObject gamePointObject;

	protected override int GamePointRewardAmount => 0;

	protected override bool HasVisualsInPlaymode => false;

	public override bool HasInputConnector => false;

	public override bool HasOutputConnector => false;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public MVGamePoint(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	private void Create()
	{
	}

	public override void Initialize()
	{
	}

	public override void Destroy()
	{
	}

	private void Enter(object sender, TriggerEventArgs e)
	{
	}

	private void SetVisible()
	{
	}

	public override void Reset()
	{
	}

	private void OnWinningConditionFulfilled(IWinningCondition winningCondition)
	{
	}

	private void HandleStandaloneDisabling()
	{
	}

	private void Disable()
	{
	}

	private void UpdateCanRespawn(Dictionary<object, object> newData)
	{
	}

	public override void OnDataUpdate()
	{
	}

	public override void PartialUpdateWOData(Dictionary<object, object> woData)
	{
	}

	protected override void OnUpdate()
	{
	}
}
