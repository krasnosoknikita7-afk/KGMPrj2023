using System.Collections.Generic;

public class MVSpawnPointYellow : MVSpawnPoint
{
	public override MVWorldObjectDocumentationType DocumentationType => MVWorldObjectDocumentationType.Missing;

	public MVSpawnPointYellow(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}
}
