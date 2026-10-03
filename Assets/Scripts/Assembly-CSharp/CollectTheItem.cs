using System.Collections.Generic;

public class CollectTheItem : MVBlueprintBase
{
	private enum LinePositionIndex
	{
		DropOff = 0,
		Collectable = 1
	}

	private CollectTheItemDropOff dropOff;

	private CollectTheItemCollectable collectable;

	private CollectTheItemLineObject objectPrefab;

	private bool hasInitializedReferences;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public int WoKeyInstance { get; set; }

	public int DropOffId => 0;

	public bool HasDropOff => false;

	public CollectTheItem(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null)
	{
	}

	public override void Initialize()
	{
	}

	public void SetupReferences()
	{
	}

	private void OnDropOffPositionChanged(MVWorldObjectClient arg0, PositionChangedEventArgs positionChangedEventArgs)
	{
	}

	private void OnCollectablePositionChanged(MVWorldObjectClient arg0, PositionChangedEventArgs positionChangedEventArgs)
	{
	}

	public bool GetDoesWoFitDropOff(int keyId)
	{
		return false;
	}

	private MVWorldObjectClient RetrieveWorldObject(Dictionary<object, object> table, string id)
	{
		return null;
	}
}
