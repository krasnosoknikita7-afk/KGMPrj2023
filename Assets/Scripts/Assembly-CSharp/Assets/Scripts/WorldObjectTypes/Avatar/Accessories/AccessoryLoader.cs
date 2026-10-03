using System;
using System.Collections.Generic;
using UnityEngine.Networking;

namespace Assets.Scripts.WorldObjectTypes.Avatar.Accessories
{
	public class AccessoryLoader
	{
		private class Request
		{
			private Action<AvatarAccessory> accessoryCreatedCallback;

			private AccessoryLoaderRequest accessoryLoaderRequest;

			public string SubUrl => null;

			public Request(Action<AvatarAccessory> accessoryCreatedCallback, AccessoryLoaderRequest accessoryLoaderRequest)
			{
			}

			public void Callback(AvatarAccessory avatarAccessory)
			{
			}

			public void Destroy()
			{
			}
		}

		private class AccessoryLoaderRequest
		{
			private readonly int id;

			private Action<int, AvatarAccessory> accessoryCreatedCallback;

			private readonly string subUrl;

			public string SubUrl => null;

			public AccessoryLoaderRequest(int id, Action<int, AvatarAccessory> accessoryCreatedCallback, string subUrl)
			{
			}

			public void Remove()
			{
			}

			public void LoadAccessory()
			{
			}

			private void Callback(UnityWebRequest www)
			{
			}
		}

		private int id;

		private Dictionary<int, Request> requests;

		public void LoadAccessory(string url, Action<AvatarAccessory> accessoryCreatedExternalCallback)
		{
		}

		private void AddRequest(AccessoryLoaderRequest accessoryLoaderRequest, Action<AvatarAccessory> accessoryCreatedExternalCallback)
		{
		}

		private void AccessoryCreatedInternalCallback(int doneId, AvatarAccessory avatarAccessory)
		{
		}

		public void Destroy()
		{
		}
	}
}
