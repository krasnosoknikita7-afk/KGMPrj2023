using System.Collections.Generic;
using MV.WorldObject.HighlightSystem;
using MV.WorldObject.HighlightSystem.HighlightPayloads;

public static class HighlightManager
{
	private static Dictionary<int, AvailableHighlightData> highlightDatas;

	public static List<Highlight<T>> GetHighLights<T>(HighlightType highlightType) where T : HighlightPayloadBase
	{
		return null;
	}

	public static void Init(string availableHighlightDatasString)
	{
	}

	public static void Reset()
	{
	}

	public static void SetHighlightToSeen(int highlightId)
	{
	}
}
