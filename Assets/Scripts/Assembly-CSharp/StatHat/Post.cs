using System.Collections.Generic;

namespace StatHat
{
	public static class Post
	{
		private class FormPoster
		{
			private Dictionary<string, string> Parameters;

			private string RelUrl;

			private string BaseUrl;

			public FormPoster(string base_url, string rel_url, Dictionary<string, string> parameters)
			{
			}

			private void PostForm()
			{
			}

			private byte[] CreatePostData()
			{
				return null;
			}

			private string encodeUriComponent(string s)
			{
				return null;
			}
		}

		private const string BaseUrl = "https://api.stathat.com";

		public static void Counter(string key, string ukey, float count)
		{
		}

		public static void Counter(string key, string ukey, int count)
		{
		}

		public static void Value(string key, string ukey, int value)
		{
		}

		public static void EzCounter(string ezkey, string stat, int count)
		{
		}

		public static void EzValue(string ezkey, string stat, float value)
		{
		}

		public static void EzValue(string ezkey, string stat, int value)
		{
		}

		public static void Value(string key, string ukey, float value)
		{
		}

		public static void EzCounter(string ezkey, string stat, float count)
		{
		}
	}
}
