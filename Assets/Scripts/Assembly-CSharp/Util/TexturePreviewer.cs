using UnityEngine;

namespace Util
{
	public class TexturePreviewer : MonoBehaviour
	{
		private static TexturePreviewer _instance;

		public Texture tex;

		public static TexturePreviewer Instance => null;
	}
}
