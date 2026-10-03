using System.Collections.Generic;
using UnityEngine;

public class MVBlueprintBase : MVGroup
{
	public const string BlueprintDataKey = "BlueprintData";

	protected Dictionary<object, object> blueprintData;

	protected Dictionary<object, object> childIdMap;

	protected Dictionary<object, object> idChildMap;

	public MVBlueprintBase(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base((Dictionary<object, object>)null, (GameObject)null, (Dictionary<int, MVWorldObjectClient>)null)
	{
	}

	public MVBlueprintBase(Dictionary<object, object> data, ObjectPrefab prefabObject, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base((Dictionary<object, object>)null, (GameObject)null, (Dictionary<int, MVWorldObjectClient>)null)
	{
	}

	public MVBlueprintBase(Dictionary<object, object> data, GameObject prefabObject, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base((Dictionary<object, object>)null, (GameObject)null, (Dictionary<int, MVWorldObjectClient>)null)
	{
	}

	public override void Initialize()
	{
	}

	public override void Compare(MVWorldObjectClient wo, bool visibleCubesOnly, ref int matchingCubeCount, ref int investigatedCubeCount)
	{
	}

	public override bool CompareWithKoGaMaPackage(MVWorldObjectClient wo, KoGaMaPackageClient koGaMaPackageClient, ref int insertedByProfileId)
	{
		return false;
	}

	protected bool CompareWorldObjectsInChildrenMap(MVWorldObjectClient wo, KoGaMaPackageClient koGaMaPackageClient, List<string> compareChildren, ref int insertedByProfileId)
	{
		return false;
	}

	private void MapDataToFields()
	{
	}

	public override MVWorldObjectClient Clone(int ownerActorNumber, int cloneGroupId, CloneBookkeeping cloneBookkeeping, Dictionary<int, MVWorldObjectClient> worldObjects, Dictionary<int, RuntimePrototypeCubeModel> prototypes)
	{
		return null;
	}

	public MVWorldObjectClient GetChild(string child)
	{
		return null;
	}

	public override void OnDataUpdate()
	{
	}
}
