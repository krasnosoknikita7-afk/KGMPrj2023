using UnityEngine;

namespace AntiHack
{
	public class TextureIntegrityChecker : ScriptableObject
	{
		[SerializeField]
		private MaterialPlaneRenderer materialPlaneRenderer;

		public void Initialize()
		{
		}

		public bool VerifyTextureIntegrity()
		{
			return false;
		}
	}
}
