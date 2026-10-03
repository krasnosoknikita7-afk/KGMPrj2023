using System.Collections.Generic;

public class MVSentryGunBlueprint : MVBlueprintBase
{
	private MVCubeModelInstance editableCubes;

	private MVSentryGun gun;

	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public MVCubeModelBase EditableCubesWO => null;

	public MVSentryGunBlueprint(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null)
	{
	}

	public override void Initialize()
	{
	}

	public override void InitializeInventory()
	{
	}

	public void InitializeCommon()
	{
	}

	public override bool CompareWithKoGaMaPackage(MVWorldObjectClient wo, KoGaMaPackageClient koGaMaPackageClient, ref int insertedByProfileId)
	{
		return false;
	}

	public override bool OnEnterObject(EditorStateMachine e)
	{
		return false;
	}

	public override bool OnExitObject(EditorStateMachine e)
	{
		return false;
	}
}
