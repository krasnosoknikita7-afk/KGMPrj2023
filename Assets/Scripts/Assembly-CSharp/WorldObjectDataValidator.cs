using System.Collections.Generic;

public static class WorldObjectDataValidator
{
	private static Dictionary<object, object> lazyAddedData;

	public static void Validate(MVWorldObjectClient wo, string key, object value)
	{
	}

	private static bool ValidateForGivenData(Dictionary<object, object> data, string key, object value, string dataName = "")
	{
		return false;
	}
}
