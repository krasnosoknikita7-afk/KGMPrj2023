using System;
using UnityEngine.Networking;

public class TextureRequest : GetRequest
{
	private bool ReadableTextureData { get; set; }

	public TextureRequest(string path, Action<UnityWebRequest> callback, WWWRequestPriority requestPriority, bool readable = false)
		: base(null, null, WWWRequestPriority.WaitUntilSyncronizingIsDone)
	{
	}

	protected override UnityWebRequest Create()
	{
		return null;
	}
}
