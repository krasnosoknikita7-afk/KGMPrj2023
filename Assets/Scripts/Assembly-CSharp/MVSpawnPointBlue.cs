using System.Collections.Generic;

public class MVSpawnPointBlue : MVSpawnPoint
{
	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public MVSpawnPointBlue(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}
}
