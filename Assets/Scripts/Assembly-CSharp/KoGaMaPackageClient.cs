using System.Collections.Generic;
using MV.WorldObject;

public class KoGaMaPackageClient
{
	public Dictionary<int, RuntimePrototypeCubeModel> prototypes;

	public Dictionary<int, MVWorldObjectClient> worldObjects;

	public Dictionary<int, Link> links;

	public Dictionary<int, ObjectLink> objectLinks;

	public int worldObjectRoot;

	public KoGaMaPackageClient(BytePacker koGaMaData, bool readRuntimeValues)
	{
	}

	public void InventoryInitialize()
	{
	}

	public void Destroy()
	{
	}

	public void HandleDeserializedData(Dictionary<object, object> returnData, KogamaDataType dataType)
	{
	}

	private void AddLink(Dictionary<object, object> data)
	{
	}

	private void AddObjectLink(Dictionary<object, object> data)
	{
	}

	private void AddPrototype(Dictionary<object, object> data)
	{
	}

	private void AddWorldObject(Dictionary<object, object> data)
	{
	}

	public static float Compare(KoGaMaPackageClient koGaMaPackageClientOriginal, KoGaMaPackageClient koGaMaPackageClientDesendant)
	{
		return 0f;
	}

	public static MVWorldObjectClient WorldObjectFactory(Dictionary<object, object> worldObjectData, Dictionary<int, MVWorldObjectClient> worldObjects, Dictionary<int, RuntimePrototypeCubeModel> prototypes)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}
}
