using System.Collections.Generic;
using UnityEngine;

namespace AntiHack
{
	public class MaterialPlaneRenderer : MonoBehaviour
	{
		[SerializeField]
		private Camera cam;

		[SerializeField]
		private Mesh plane;

		[SerializeField]
		private Material material;

		[SerializeField]
		private List<Texture2D> textures;

		private List<byte> hashes;

		private RenderTextureDescriptor renderTextureDesc;

		private RenderTexture renderTexture;

		private static bool errorReportSent;

		protected void OnValidate()
		{
		}

		protected void OnPostRender()
		{
		}

		public void Initialize()
		{
		}

		public bool VerifyTextureIntegrity()
		{
			return false;
		}

		private void GenerateNewHashes()
		{
		}

		private void OnPostRender_GenerateNewHashes()
		{
		}

		private byte CalculateHash(RenderTexture renderTexture)
		{
			return 0;
		}

		private byte CalculateHash(Texture2D texture)
		{
			return 0;
		}
	}
}
